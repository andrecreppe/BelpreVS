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
        //Criptografia
        Criptografia cripto = new Criptografia();

        //Dados de ROOT
        private string cpf_mestre = "12345678901";
        public string getCPF_Mestre()
        {
            return cpf_mestre;
        }
        private string senha_mestre = "123321";

        //Inicialição
        public frmLogin()
        {
            InitializeComponent();

            txtAviso.Text = "";
        }


        //Validando se o CapsLock está ligado
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


        //Efetua o login
        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                string cpf, sql;

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
                    sql = "SELECT nome, sexo, senha FROM pacientes WHERE cpf = " + cpf;
                else
                    sql = "SELECT nome, sexo, senha FROM medicos WHERE cpf = " + cpf;

                NpgsqlDataReader dr = conexao.Select(sql);
                if (dr.Read())
                {
                    //Testar se ele é médico
                    if(cripto.ComparaMD5(txtSenha.Text, dr["senha"].ToString())
                        && !radPaciente.Checked)
                    {
                        frmMedico med = new frmMedico(dr["nome"].ToString(), dr["sexo"].ToString());

                        dr.Close();

                        this.Hide();
                        med.ShowDialog();
                        this.Close();
                    }
                    //Testar se ele 
                    else if(cripto.ComparaMD5(txtSenha.Text, dr["senha"].ToString())
                        && radPaciente.Checked)
                    {
                        frmPacientes pac = new frmPacientes(dr["nome"].ToString(), dr["sexo"].ToString());

                        dr.Close();

                        this.Hide();
                        pac.ShowDialog();
                        this.Close();
                    }
                    //Erro na Senha
                    else
                    {
                        dr.Close();

                        MessageBox.Show("SENHA inválida! Redigite.", "Belpre",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtSenha.Text = "";
                    }
                }
                //Erro no CPF
                else
                {
                    dr.Close();

                    MessageBox.Show("CPF invalido ou inexistente! Redigite.", "Belpre",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    mskCPF.Text = "";
                    mskCPF.TextMaskFormat = MaskFormat.IncludeLiterals;

                    txtSenha.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a operação!" + "\n\nMais informações: " + ex.Message,
                    "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
