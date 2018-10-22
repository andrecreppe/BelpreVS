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
//User input
using Npgsql;
using static Belpre.Program;


namespace Belpre
{
    public partial class frmMASTER : Form
    {
        Criptografia cripto = new Criptografia();

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
            if (!String.IsNullOrWhiteSpace(txtNomeCad.Text))
                param.Add(txtNomeCad.Text);
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo SOBRENOME
            if (!String.IsNullOrWhiteSpace(txtSobrenCad.Text))
                param.Add(txtSobrenCad.Text);
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo CPF
            if (!String.IsNullOrWhiteSpace(mskCPFCad.Text))
            {
                frmLogin login = new frmLogin();

                mskCPFCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (mskCPFCad.Text == login.getCPF_Mestre())
                {
                    MessageBox.Show("Esse CPF não pode ser utilizado!\nDigite outro no lugar.", "Belpre",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                param.Add(Convert.ToInt64(mskCPFCad.Text));
                mskCPFCad.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo SEXO
            if (radFemCad.Checked)
                param.Add("F");
            else if (radMascCad.Checked)
                param.Add("M");
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo NASCIMENTO
            if (!String.IsNullOrWhiteSpace(mskNascmCad.Text))
            {
                try
                {
                    CultureInfo culture = new CultureInfo("pt-BR");
                    DateTime data_com_hora = Convert.ToDateTime(mskNascmCad.Text, culture);

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
            if (!String.IsNullOrWhiteSpace(mskCellCad.Text))
            {
                mskCellCad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                param.Add(Convert.ToInt64(mskCellCad.Text));

                mskCellCad.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo SENHA
            if (!String.IsNullOrWhiteSpace(txtSenhaCad.Text))
                param.Add(cripto.RetornarMD5(txtSenhaCad.Text));
            else
            {
                ErroPreenchimento();
                return;
            }

            //Envia ao banco de dados
            sql = "INSERT INTO medicos VALUES" +
                "(DEFAULT, @1, @2, @3, @4, @5, @6, @7);";

            conexao.Run(sql, param);

            MessageBox.Show("Cadastro efetuado com sucesso!\n" + txtNomeCad.Text + " bem-vindo a Belpre!",
                "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpaCampos();
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
            txtNomeCad.Text = "";
            txtSobrenCad.Text = "";
            txtSenhaCad.Text = "";

            mskCellCad.Text = "";
            mskCPFCad.Text = "";
            mskNascmCad.Text = "";

            radFemCad.Checked = false;
            radMascCad.Checked = false;
        }

        //Voltar ao form de LOGIN
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        //Entrou na aba de consulta
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

        //Selecionou a linha de um cadastro -> Vai pra alteração
        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            Int64 id = Convert.ToInt64(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells[0].Value);

          //  txtId.Text = id.ToString();
           // tabPaginas.SelectedIndex = 0;

            /*ALTERAÇÃO AQUI*/
           // txtId_Validating(txtId, new CancelEventArgs());
        }

        //Carrega um cpf
        private void mskCPFAlt_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                mskCPFAlt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (!String.IsNullOrWhiteSpace(mskCPFAlt.Text))
                {
                    List<object> param = new List<object>();
                    param.Add(Convert.ToInt64(mskCPFAlt.Text));

                    string sql = "SELECT * FROM medicos " +
                            "WHERE cpf = @1";

                    NpgsqlDataReader dr = conexao.Select(sql, param);

                    if (dr.Read())
                    {
                        txtNomeAlt.Text = dr["nome"].ToString();
                        txtSobrAlt.Text = dr["sobrenome"].ToString();
                        txtSenhaAlt.Text = dr["senha"].ToString();
                        mskCPFAlt.Text = dr["cpf"].ToString();
                        mskNascmAlt.Text = dr["data_nascm"].ToString();
                        mskCelAlt.Text = dr["celular"].ToString();
                        if (dr["sexo"].ToString() == "M")
                            radMascAlt.Checked = true;
                        else
                            radFemAlt.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Não foi localizado nenhum médico com este CPF!",
                            "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        LimpaCamposAlt();
                    }

                    dr.Close();
                }

                mskCPFAlt.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!\nMais informações: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpaCamposAlt()
        {
            txtNomeAlt.Text = "";
            txtSobrAlt.Text = "";
            txtSenhaAlt.Text = "";

            mskCelAlt.Text = "";
            mskCPFAlt.Text = "";
            mskNascmAlt.Text = "";

            radFemAlt.Checked = false;
            radFemAlt.Checked = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            List<object> param = new List<object>();

            string sql;

            //Campo NOME
            if (!String.IsNullOrWhiteSpace(txtNomeAlt.Text))
                param.Add(txtNomeAlt.Text);
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo SOBRENOME
            if (!String.IsNullOrWhiteSpace(txtSobrAlt.Text))
                param.Add(txtSobrAlt.Text);
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo CPF
            if (!String.IsNullOrWhiteSpace(mskCPFAlt.Text))
            {
                frmLogin login = new frmLogin();

                mskCPFAlt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (mskCPFAlt.Text == login.getCPF_Mestre())
                {
                    MessageBox.Show("Esse CPF não pode ser utilizado!\nDigite outro no lugar.", "Belpre",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                param.Add(Convert.ToInt64(mskCPFAlt.Text));
                mskCPFAlt.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo SEXO
            if (radFemAlt.Checked)
                param.Add("F");
            else if (radMascAlt.Checked)
                param.Add("M");
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo NASCIMENTO
            if (!String.IsNullOrWhiteSpace(mskNascmAlt.Text))
            {
                try
                {
                    CultureInfo culture = new CultureInfo("pt-BR");
                    DateTime data_com_hora = Convert.ToDateTime(mskNascmAlt.Text, culture);

                    param.Add(data_com_hora.Date);
                }
                catch (Exception ex)
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
            if (!String.IsNullOrWhiteSpace(mskCelAlt.Text))
            {
                mskCelAlt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                param.Add(Convert.ToInt64(mskCelAlt.Text));

                mskCelAlt.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            else
            {
                ErroPreenchimento();
                return;
            }
            //Campo SENHA
            if (!String.IsNullOrWhiteSpace(txtSenhaAlt.Text))
                param.Add(txtSenhaAlt.Text);
            else
            {
                ErroPreenchimento();
                return;
            }
            /*
            //Envia ao banco de dados
            sql = "INSERT INTO medicos VALUES" +
                "(DEFAULT, @1, @2, @3, @4, @5, @6, @7);";
           
            ~converter a senha = md5

            conexao.Run(sql, param);

            MessageBox.Show("Cadastro efetuado com sucesso!\n" + txtNomeCad.Text + " bem-vindo a Belpre!",
                "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpaCampos();*/
        }
    }
}
