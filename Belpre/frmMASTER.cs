using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Npgsql;
using static Belpre.Program;

namespace Belpre
{
    public partial class frmMASTER : Form
    {
        public frmMASTER()
        {
            InitializeComponent();
        }

        //Change the index based on the label clicked
        private void lblCadastro_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 1;
        }
        private void lblConsulta_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 2;
        }

        //Efetua o cadastro no banco
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<object> param = new List<object>();

            string sql;

            //Campo NOME
            if (!String.IsNullOrWhiteSpace(txtNome.Text))
                param.Add(txtNome.Text);
            else
            {
                ErroPreenchimento();
                return;
            }

            //Campo SOBRENOME
            if (!String.IsNullOrWhiteSpace(txtSobren.Text))
                param.Add(txtSobren.Text);
            else
            {
                ErroPreenchimento();
                return;
            }

            //Campo CPF
            if (!String.IsNullOrWhiteSpace(mskCPF.Text))
            {
                frmLogin login = new frmLogin();

                mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (mskCPF.Text == login.getCPF_Mestre())
                {
                    MessageBox.Show("Esse CPF não pode ser utilizado!\nDigite outro no lugar.", "Belpre",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                param.Add(Convert.ToInt64(mskCPF.Text));
                mskCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                ErroPreenchimento();
                return;
            }

            //Campo SEXO
            if (radFem.Checked)
                param.Add("F");
            else if (radMasc.Checked)
                param.Add("M");
            else
            {
                ErroPreenchimento();
                return;
            }

            //Campo NASCIMENTO
            if (!String.IsNullOrWhiteSpace(mskNascm.Text))
            {
                try
                {
                    CultureInfo culture = new CultureInfo("pt-BR");
                    DateTime data_com_hora = Convert.ToDateTime(mskNascm.Text, culture);

                    param.Add(data_com_hora.Date);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro!\nMais informações: " + ex.Message, "Belpre",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                ErroPreenchimento();
                return;
            }

            //Campo CELULAR
            if (!String.IsNullOrWhiteSpace(mskCell.Text))
            {
                mskCell.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                param.Add(Convert.ToInt64(mskCell.Text));

                mskCell.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                ErroPreenchimento();
                return;
            }

            //Campo SENHA
            if (!String.IsNullOrWhiteSpace(txtSenha.Text))
                param.Add(txtSenha.Text);
            else
            {
                ErroPreenchimento();
                return;
            }

            //Envia ao banco de dados
            sql = "INSERT INTO medicos VALUES" +
                "(DEFAULT, @1, @2, @3, @4, @5, @6, @7);";

            conexao.Run(sql, param);

            MessageBox.Show("Cadastro efetuado com sucesso!\n" + txtNome.Text + " bem-vindo a Belpre!",
                "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ErroPreenchimento()
        {
            MessageBox.Show("Existem campos sem preencher!", "Belpre", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpa os campos de cadastro
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            txtNome.Text = "";
            txtSobren.Text = "";
            txtSenha.Text = "";

            mskCell.Text = "";
            mskCPF.Text = "";
            mskNascm.Text = "";

            radFem.Checked = false;
            radMasc.Checked = false;
        }

        //Voltar ao form de LOGIN
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        //Trocou o index - carregou o DGV
        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se a selecionada é a consulta
            if (tabAdmin.SelectedTab.Name == "tabConsulta")
            {
                string sql = "SELECT id_med, nome, sobrenome, cpf" +
                    " FROM medicos " +
                    "ORDER BY id_med;";

                DataSet ds = new DataSet();
                ds = conexao.SelectDataSet(sql);

                //Carregar o grid com os dados do DatSet
                dgvConsulta.DataSource = ds.Tables[0];
            }
        }
        //Recarregar o DGV 
        private void picReload_Click(object sender, EventArgs e)
        {
            dgvConsulta.Refresh();
            dgvConsulta.DataSource = null;

            tabAdmin_SelectedIndexChanged(sender, new CancelEventArgs());
        }

        //Selecionou a linha de um cadastro
        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells[0].Value);

          //  txtId.Text = id.ToString();
           // tabPaginas.SelectedIndex = 0;

            /*ALTERAÇÃO AQUI*/
           // txtId_Validating(txtId, new CancelEventArgs());
        }
    }
}
