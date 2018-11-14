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
    using FluentDateTime;
    using Npgsql;
    using static Belpre.Program;

namespace Belpre
{
    public partial class frmMedico : Form
    {
        private string logado, sexo;

        private int index_agenda = 0;

        Criptografia cripto = new Criptografia();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
                frm.ShowDialog();
            this.Close();
        }

        public frmMedico(string recebido, string recsexo)
        {
            InitializeComponent();

            logado = recebido;
            lblBemVindo.Text = "Bem-Vindo " + logado + "!";

            sexo = recsexo;
            picMedicoa.Image = Image.FromFile(@"Images\" + sexo + ".png");
        }

        //--------------------------------------------------------------------------------------//

        private void tabMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMedico.SelectedIndex == 1) //Agenda
            {
                index_agenda = 0;
                UpdateDateAgenda(index_agenda);
            }
            else if(tabMedico.SelectedIndex == 3) //Pacientes
            {
                LoadPacientes();
            }
        }

        //--------------------------------------------------------------------------------------//

        private void picAvancar_Click(object sender, EventArgs e)
        {
            index_agenda++;
            UpdateDateAgenda(index_agenda);
        }
        private void picVoltar_Click(object sender, EventArgs e)
        {
            index_agenda--;
            UpdateDateAgenda(index_agenda);
        }
        private void btnHoje_Click(object sender, EventArgs e)
        {
            index_agenda = 0;
            UpdateDateAgenda(index_agenda);
        }

        private void UpdateDateAgenda(int mult)
        {
            string d1, d2, d3, d4, d5, d6, d7;
            int dia, add; 
            bool red;

            red = true;
            if(mult != 0)
                red = false;

            dia = (int)DateTime.Now.DayOfWeek;
            add = -dia + (7*mult);

            d1 = DateTime.Now.AddDays(add).ToString("dd/MM/yy");
            d2 = DateTime.Now.AddDays(1 + add).ToString("dd/MM/yy");
            d3 = DateTime.Now.AddDays(2 + add).ToString("dd/MM/yy");
            d4 = DateTime.Now.AddDays(3 + add).ToString("dd/MM/yy");
            d5 = DateTime.Now.AddDays(4 + add).ToString("dd/MM/yy");
            d6 = DateTime.Now.AddDays(5 + add).ToString("dd/MM/yy");
            d7 = DateTime.Now.AddDays(6 + add).ToString("dd/MM/yy");

            lblDomingo.Text = d1;
            lblSegunda.Text = d2;
            lblTerca.Text = d3;
            lblQuarta.Text = d4;
            lblQuinta.Text = d5;
            lblSexta.Text = d6;
            lblSabado.Text = d7;

            if(red)
            {
                if (dia == 0)
                    lblDomingo.ForeColor = Color.Red;
                else if (dia == 1)
                    lblSegunda.ForeColor = Color.Red;
                else if (dia == 2)
                    lblTerca.ForeColor = Color.Red;
                else if (dia == 3)
                    lblQuarta.ForeColor = Color.Red;
                else if (dia == 4)
                    lblQuinta.ForeColor = Color.Red;
                else if (dia == 5)
                    lblSexta.ForeColor = Color.Red;
                else if (dia == 6)
                    lblSabado.ForeColor = Color.Red;
            }
            else
            {
                if (dia == 0)
                    lblDomingo.ForeColor = Color.Black;
                else if (dia == 1)
                    lblSegunda.ForeColor = Color.Black;
                else if (dia == 2)
                    lblTerca.ForeColor = Color.Black;
                else if (dia == 3)
                    lblQuarta.ForeColor = Color.Black;
                else if (dia == 4)
                    lblQuinta.ForeColor = Color.Black;
                else if (dia == 5)
                    lblSexta.ForeColor = Color.Black;
                else if (dia == 6)
                    lblSabado.ForeColor = Color.Black;
            }
        }

        //--------------------------------------------------------------------------------------//

        //cada DGV tem um request data baseado na data que colocamos no label em cima
        //fazer uma funcao geral que retorna pra cada item

        //--------------------------------------------------------------------------------------//

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
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
                if (!String.IsNullOrWhiteSpace(txtSobreCad.Text))
                    param.Add(txtSobreCad.Text);
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
                sql = "INSERT INTO pacientes VALUES" +
                    "(DEFAULT, @1, @2, @3, @4, @5, @6, @7, 'FALSE');";

                conexao.Run(sql, param);

                MessageBox.Show("Cadastro efetuado com sucesso!\n" + "Bem-vindo a Belpre, " + txtNomeCad.Text + "!",
                    "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void ErroPreenchimento()
        {
            MessageBox.Show("Existem campos sem preencher!", "Belpre",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpaCad_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void LimpaCampos()
        {
            txtNomeCad.Text = "";
            txtSobreCad.Text = "";
            txtSenhaCad.Text = "";

            mskCellCad.Text = "";
            mskCPFCad.Text = "";
            mskNascmCad.Text = "";

            radFemCad.Checked = false;
            radMascCad.Checked = false;
        }

        //--------------------------------------------------------------------------------------//

        private void LoadPacientes()
        {
            try
            {
                string sql = "SELECT nome, sobrenome, cpf, celular, data_nascm " +
                        " FROM pacientes " +
                        "ORDER BY id_pac;";

                DataSet ds = new DataSet();
                ds = conexao.SelectDataSet(sql);

                //Carregar o grid com os dados do DatSet
                dgvConsulta.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            dgvConsulta.Refresh();
            dgvConsulta.DataSource = null;

            LoadPacientes();
        }

        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            /*
            try
            {
                Int64 cpf = Convert.ToInt64(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells[3].Value);

                mskCPFAlt.Text = cpf.ToString();
                tabAdmin.SelectedIndex = 3;

                mskCPFAlt_Validating(mskCPFAlt.Text, new CancelEventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
        }

        //--------------------------------------------------------------------------------------//
    }
}
