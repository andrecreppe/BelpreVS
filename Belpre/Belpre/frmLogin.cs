using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//User input
    using Npgsql;
    using static Belpre.Program;

namespace Belpre
{
    public partial class frmLogin : Form
    {
        Criptografia cripto = new Criptografia();

        //Dados de ROOT
        private string cpf_mestre = "00000000000"; //número de 11 dígitos!
        public string getCPF_Mestre()
        {
            return cpf_mestre;
        }
        private string senha_mestre = "123321";

        //------------------------------------------MAIN--------------------------------------------//

        public frmLogin()
        {
            InitializeComponent();

            txtAviso.Text = "";
        }

        //----------------------------------TYPING VALIDATION----------------------------------------//

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                txtAviso.Text = "CAPSLOCK Ligado!";
            }
            else
            {
                txtAviso.Text = "";
            }
        }
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                txtAviso.Text = "CAPSLOCK Ligado!";
            }
            else
            {
                txtAviso.Text = "";
            }
        }

        //------------------------------------------LOGIN----------------------------------------//

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf, sql;
                string senha, excluido, nome, sexo, id;

                List<object> param = new List<object>();

                //Pegar o CPF
                mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    cpf = mskCPF.Text;
                mskCPF.TextMaskFormat = MaskFormat.IncludeLiterals;

                //Login do adm mestre -> Cadastro dos médicos
                if (cpf == cpf_mestre && txtSenha.Text == senha_mestre)
                {
                    frmMASTER master = new frmMASTER();
                    this.Hide();
                    master.ShowDialog();
                    this.Close();

                    return;
                }

                //Teste de usuários normais
                if (radPaciente.Checked)
                {
                    sql = "SELECT * FROM pacientes WHERE cpf=@1";
                    param.Add(Convert.ToInt64(cpf));
                }
                else
                {
                    sql = "SELECT * FROM medicos WHERE cpf=@1";
                    param.Add(Convert.ToInt64(cpf));
                }

                NpgsqlDataReader dr = conexao.Select(sql, param);
                if (dr.Read())
                {
                    //Campos de análise
                    nome = dr["nome"].ToString();
                    senha = dr["senha"].ToString();
                    excluido = dr["excluido"].ToString();
                    sexo = dr["sexo"].ToString();
                    if(radPaciente.Checked)
                        id = dr["id_pac"].ToString();
                    else
                        id = dr["id_med"].ToString();

                    dr.Close();

                    //Testar se ele é médico
                    if (cripto.ComparaMD5(txtSenha.Text, senha)
                        && !radPaciente.Checked && excluido == "False")
                    {
                        frmMedico med = 
                            new frmMedico(nome, sexo, Convert.ToInt32(id));

                        this.Hide();
                        med.ShowDialog();
                        this.Close();
                    }
                    //Testar se ele 
                    else if(cripto.ComparaMD5(txtSenha.Text, senha)
                        && radPaciente.Checked && excluido == "False")
                    {
                        frmPacientes pac = 
                            new frmPacientes(Convert.ToInt32(id));

                        this.Hide();
                        pac.ShowDialog();
                        this.Close();
                    }
                    //Erros
                    else
                    {
                        //Ele está excluido
                        if(excluido == "True")
                        {
                            MessageBox.Show("Erro! Este usuário está DESATIVADO!", "Belpre",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            LimpaCampos();
                        }
                        else //Na senha
                        {
                            MessageBox.Show("SENHA inválida! Redigite.", "Belpre",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txtSenha.Text = "";
                            txtSenha.Focus();
                        }
                    }
                }
                //Erro no CPF
                else
                {
                    MessageBox.Show("CPF invalido ou inexistente! Redigite.", "Belpre",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    LimpaCampos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a operação!" + "\n\nMais informações: " + ex.Message,
                    "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------------------GLOBAL FUNCTIONS--------------------------------------------//

        private void LimpaCampos()
        {
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCPF.Text = "";
            mskCPF.TextMaskFormat = MaskFormat.IncludeLiterals;

            txtSenha.Text = "";

            mskCPF.Focus();
        }
    }
}
