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

        private int id_med;
        private int index_agenda = 0;
        private int hora_min = 7, hora_max = 18, temp_cons = 15;

        private bool isCadastro = true;

        private Criptografia cripto = new Criptografia();

        //--------------------------------------MAIN-----------------------------------//

        public frmMedico(string recebido, string recsexo, int id_medico)
        {
            InitializeComponent();

            //Nome do médico(a)
            logado = recebido;
            lblBemVindo.Text = "Bem-Vindo " + logado + "!";

            //Sexo do médico(a)
            sexo = recsexo;
            picMedicoa.Image = Image.FromFile(@"Images\" + sexo + ".png");

            //ID do médico(a)
            id_med = id_medico;

            //Data de hoje
            lblHoje.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Consultas para hoje
            ConsultasHoje();

            //Setup de elementos
            cmbIDOculto.Hide();

            //Is Cadastro
            LimpaCamposCadastro();
        }

        //-----------------------------------TAB CONTROL-----------------------------------------//

        private void tabMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string horario;

            if (tabMedico.SelectedIndex == 1) //Agenda
            {
                index_agenda = 0;
                UpdateDateAgenda(index_agenda);
            }
            else if (tabMedico.SelectedIndex == 2) //Agendar
            {
                //Limpar
                cmbHora.Items.Clear();
                cmbMinutos.Items.Clear();

                //Preencher os combos de datas
                for (int i = hora_min; i < hora_max; i++)
                {
                    if (i < 10)
                        horario = "0" + i.ToString();
                    else
                        horario = i.ToString();

                    cmbHora.Items.Add(horario);
                }
                for (int i = 0; i < 60; i += temp_cons)
                {
                    if (i == 0)
                        horario = "00";
                    else
                        horario = i.ToString();

                    cmbMinutos.Items.Add(i.ToString());
                }

                LoadPacientes(1);
            }
            else if (tabMedico.SelectedIndex == 3) //Pacientes
            {
                LoadPacientes(2);
            }
        }

        //------------------------------------FIRST PAGE ---------------------------------------//

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        //--------------------------------------AGENDA----------------------------------------//

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

        private void picReload_Click(object sender, EventArgs e)
        {
            dgvConsulta.Refresh();
            dgvConsulta.DataSource = null;

            LoadPacientes(2);
        }

        private void UpdateDateAgenda(int mult)
        {
            string d1, d2, d3, d4, d5, d6, d7;
            string sql1, sql2, sql3, sql4, sql5, sql6, sql7;
            int dia, add; 
            bool red;

            //Setup
            red = true;
            if(mult != 0)
                red = false;

            dia = (int)DateTime.Now.DayOfWeek;
            add = -dia + (7*mult);

            //Prepare
            d1 = DateTime.Now.AddDays(add).ToString("dd-MM-yyyy");
                sql1 = "SELECT hora_cons AS Consultas FROM consultas WHERE data_cons='" + d1 + "' ORDER BY hora_cons";
            d2 = DateTime.Now.AddDays(1 + add).ToString("dd-MM-yyyy");
                sql2 = "SELECT hora_cons AS Consultas FROM consultas WHERE data_cons='" + d2 + "' ORDER BY hora_cons";
            d3 = DateTime.Now.AddDays(2 + add).ToString("dd-MM-yyyy");
                sql3 = "SELECT hora_cons AS Consultas FROM consultas WHERE data_cons='" + d3 + "' ORDER BY hora_cons";
            d4 = DateTime.Now.AddDays(3 + add).ToString("dd-MM-yyyy");
                sql4 = "SELECT hora_cons AS Consultas FROM consultas WHERE data_cons='" + d4 + "' ORDER BY hora_cons";
            d5 = DateTime.Now.AddDays(4 + add).ToString("dd-MM-yyyy");
                sql5 = "SELECT hora_cons AS Consultas FROM consultas WHERE data_cons='" + d5 + "' ORDER BY hora_cons";
            d6 = DateTime.Now.AddDays(5 + add).ToString("dd-MM-yyyy");
                sql6 = "SELECT hora_cons AS Consultas FROM consultas WHERE data_cons='" + d6 + "' ORDER BY hora_cons";
            d7 = DateTime.Now.AddDays(6 + add).ToString("dd-MM-yyyy");
                sql7 = "SELECT hora_cons AS Consultas FROM consultas WHERE data_cons='" + d7 + "' ORDER BY hora_cons";

            //Label set
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

            //Clear datagrid
            dgvDom.DataSource = null;
            dgvSeg.DataSource = null;
            dgvTer.DataSource = null;
            dgvQua.DataSource = null;
            dgvQui.DataSource = null;
            dgvSex.DataSource = null;
            dgvSab.DataSource = null;

            //Get events
            DataSet ds = new DataSet();

            ds = conexao.SelectDataSet(sql1);
                dgvDom.DataSource = ds.Tables[0];
            ds = conexao.SelectDataSet(sql2);
                dgvSeg.DataSource = ds.Tables[0];
            ds = conexao.SelectDataSet(sql3);
                dgvTer.DataSource = ds.Tables[0];
            ds = conexao.SelectDataSet(sql4);
                dgvQua.DataSource = ds.Tables[0];
            ds = conexao.SelectDataSet(sql5);
                dgvQui.DataSource = ds.Tables[0];
            ds = conexao.SelectDataSet(sql6);
                dgvSex.DataSource = ds.Tables[0];
            ds = conexao.SelectDataSet(sql7);
                dgvSab.DataSource = ds.Tables[0];
        }

        private void dgvDom_DoubleClick(object sender, EventArgs e)
        {
            string hr = dgvDom.Rows[dgvDom.CurrentRow.Index].Cells[0].Value.ToString();
            string dt = lblDomingo.Text;

            frmDadosConsulta frm = new frmDadosConsulta(hr, dt);
            frm.Show();
        }

        private void dgvSeg_DoubleClick(object sender, EventArgs e)
        {
            string hr = dgvSeg.Rows[dgvSeg.CurrentRow.Index].Cells[0].Value.ToString();
            string dt = lblSegunda.Text;

            frmDadosConsulta frm = new frmDadosConsulta(hr, dt);
            frm.Show();
        }

        private void dgvTer_DoubleClick(object sender, EventArgs e)
        {
            string hr = dgvTer.Rows[dgvTer.CurrentRow.Index].Cells[0].Value.ToString();
            string dt = lblTerca.Text;

            frmDadosConsulta frm = new frmDadosConsulta(hr, dt);
            frm.Show();
        }

        private void dgvQua_DoubleClick(object sender, EventArgs e)
        {
            string hr = dgvQua.Rows[dgvQua.CurrentRow.Index].Cells[0].Value.ToString();
            string dt = lblQuarta.Text;

            frmDadosConsulta frm = new frmDadosConsulta(hr, dt);
            frm.Show();
        }

        private void dgvQui_DoubleClick(object sender, EventArgs e)
        {
            string hr = dgvQui.Rows[dgvQui.CurrentRow.Index].Cells[0].Value.ToString();
            string dt = lblQuinta.Text;
                
            frmDadosConsulta frm = new frmDadosConsulta(hr, dt);
            frm.Show();
        }

        private void dgvSex_DoubleClick(object sender, EventArgs e)
        {
            string hr = dgvSex.Rows[dgvSex.CurrentRow.Index].Cells[0].Value.ToString();
            string dt = lblSexta.Text;

            frmDadosConsulta frm = new frmDadosConsulta(hr, dt);
            frm.Show();
        }

        private void dgvSab_DoubleClick(object sender, EventArgs e)
        {
            string hr = dgvSab.Rows[dgvSab.CurrentRow.Index].Cells[0].Value.ToString();
            string dt = lblSabado.Text;

            frmDadosConsulta frm = new frmDadosConsulta(hr, dt);
            frm.Show();
        }

        //--------------------------------AGENDAR CONSULTA-------------------------------------//

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIDOculto.SelectedIndex = cmbPacientes.SelectedIndex;
        }

        private void chkParticular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParticular.Checked)
            {
                cmbConvenio.SelectedIndex = -1;
                cmbConvenio.Enabled = false;
            }
            else
                cmbConvenio.Enabled = true;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            List<object> param = new List<object>();
            string aux, sql, unicode = "";

            try
            {
                //ID Médico
                param.Add(id_med);

                //ID paciente
                if (cmbPacientes.SelectedIndex == -1)
                {
                    ErroPreenchimento();
                    return;
                }
                else
                    param.Add(Convert.ToInt64(cmbIDOculto.SelectedItem));

                //Data da consulta
                if (String.IsNullOrWhiteSpace(mskDiaConsulta.Text))
                {
                    ErroPreenchimento();
                    return;
                }
                else
                {
                    try
                    {
                        CultureInfo culture = new CultureInfo("pt-BR");
                        DateTime data_com_hora = Convert.ToDateTime(mskDiaConsulta.Text, culture);

                        param.Add(data_com_hora.Date);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro!\nMais informações: " + ex.Message, "Belpre",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //Hora da consulta
                if (cmbHora.SelectedIndex == -1 || cmbMinutos.SelectedIndex == -1)
                {
                    ErroPreenchimento();
                    return;
                }
                else
                {
                    aux = cmbHora.SelectedItem.ToString() + ":" + cmbMinutos.SelectedItem.ToString() + "h";
                    param.Add(aux);

                    unicode = cmbHora.SelectedItem.ToString() + cmbMinutos.SelectedItem.ToString();
                }

                //Tipo de consulta
                if(!radConsulta.Checked && !radRetorno.Checked)
                {
                    ErroPreenchimento();
                    return;
                }
                else
                {
                    if (radConsulta.Checked)
                        param.Add("Consulta");
                    else
                        param.Add("Retorno");
                }

                //Convenio
                if (cmbConvenio.SelectedIndex == -1 && !chkParticular.Checked)
                {
                    ErroPreenchimento();
                    return;
                }
                else
                {
                    if (chkParticular.Checked)
                        param.Add("Particular");
                    else
                        param.Add(cmbConvenio.SelectedItem);
                }

                //Unicode
                mskDiaConsulta.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    unicode += mskDiaConsulta.Text;
                    param.Add(unicode);
                mskDiaConsulta.TextMaskFormat = MaskFormat.IncludeLiterals;

                label1.Text = unicode;


                sql = "INSERT INTO consultas " +
                    "VALUES(DEFAULT, @1, @2, @3, @4, @5, @6, @7, 'FALSE');";

                conexao.Run(sql, param);

                MessageBox.Show("Consulta marcada com sucesso!", "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!" + "\nMais informações: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbPacientes.Focus();
            }

            LimpaCamposConsulta();
        }

        private void btnLimpaConsulta_Click(object sender, EventArgs e)
        {
            LimpaCamposConsulta();
        }

        private void LimpaCamposConsulta()
        {
            cmbPacientes.SelectedIndex = -1;
            cmbConvenio.SelectedIndex = -1;
            cmbHora.SelectedIndex = -1;
            cmbMinutos.SelectedIndex = -1;

            chkParticular.Checked = false;

            radConsulta.Checked = false;
            radRetorno.Checked = false;

            mskDiaConsulta.Text = "";
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            mskDiaConsulta.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnAmanha_Click(object sender, EventArgs e)
        {
            mskDiaConsulta.Text = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy");
        }

        private void btnSemanaqvem_Click(object sender, EventArgs e)
        {
            mskDiaConsulta.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
        }

        //------------------------------------PACIENTES----------------------------------------//

        private void LoadPacientes(int op)
        {
            string sql;

            try
            {
                if (op == 1) //Combo consulta
                    sql = "SELECT nome, id_pac" +
                    " FROM pacientes " +
                    "ORDER BY nome;";
                else
                    sql = "SELECT nome, sobrenome, cpf, celular, data_nascm " +
                    " FROM pacientes " +
                    "ORDER BY nome;";

                DataSet ds = new DataSet();
                ds = conexao.SelectDataSet(sql);

                if (op == 1)//Combo consulta
                {
                    cmbPacientes.Items.Clear();
                    cmbIDOculto.Items.Clear();

                    foreach (DataTable table in ds.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            cmbPacientes.Items.Add(dr["nome"].ToString());
                            cmbIDOculto.Items.Add(dr["id_pac"].ToString());
                        }
                    }
                }
                else //Carregar o grid pacientes
                    dgvConsulta.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
            string sql;

            try
            {
                Int64 cpf = Convert.ToInt64(dgvConsulta.Rows[dgvConsulta.CurrentRow.Index].Cells[2].Value.ToString());

                sql = "SELECT * FROM pacientes WHERE cpf='" + cpf + "'";

                NpgsqlDataReader dr = conexao.Select(sql);

                if (dr.Read())
                {
                    txtNomeCad.Text = dr["nome"].ToString();
                    txtSobreCad.Text = dr["sobrenome"].ToString();
                    mskCPFCad.Text = cpf.ToString();
                    if (dr["sexo"].ToString() == "M")
                        radMascCad.Checked = true;
                    else
                        radFemCad.Checked = true;
                    mskNascmCad.Text = dr["data_nascm"].ToString();
                    mskCellCad.Text = dr["celular"].ToString();
                    txtSenhaCad.Text = dr["senha"].ToString();

                    tabMedico.SelectedIndex = 4;

                    btnExcReat.Show();
                    lblTitle.Text = "*Alteração*";
                    btnCadAlt.Text = "&Alterar";
                    isCadastro = false;

                    dr.Close();
                }
                else
                {
                    dr.Close();

                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------------------CADASTRO/ALTERAÇÃO PACIENTE----------------------------------------//

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (isCadastro)
                EfetuarCadastro();
            else
            {
                EfetuarAlteracao();

                LimpaCamposCadastro();
            }
        }

        private void btnLimpaCad_Click(object sender, EventArgs e)
        {
            LimpaCamposCadastro();
        }

        private void LimpaCamposCadastro()
        {
            txtNomeCad.Text = "";
            txtSobreCad.Text = "";
            txtSenhaCad.Text = "";

            mskCellCad.Text = "";
            mskCPFCad.Text = "";
            mskNascmCad.Text = "";

            radFemCad.Checked = false;
            radMascCad.Checked = false;

            btnExcReat.Hide();
            lblTitle.Text = "*Cadastro*";
            btnCadAlt.Text = "&Cadastrar";
            isCadastro = true;
        }

        private void EfetuarCadastro()
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

                LimpaCamposCadastro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void EfetuarAlteracao()
        {
            //aaaa

            //nao esquecer que senha = criptografada
        }

        //--------------------------------GLOBAL FUNCTIONS----------------------------------------//

        private void ErroPreenchimento()
        {
            MessageBox.Show("Existem campos sem preencher!", "Belpre",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConsultasHoje()
        {
            string hoje, sql;

            hoje = DateTime.Now.ToString("dd-MM-yyyy");

            sql = "SELECT COUNT(id_cons) FROM consultas WHERE data_cons='" + hoje + "'";

            NpgsqlDataReader dr = conexao.Select(sql);

            if (dr.Read())
                lblConsultas.Text = dr["count"].ToString() + " Consultas!";
            else
                lblConsultas.Text = "0 Consultas!";

            dr.Close();
        }

        //--------------------------------------------------------------------------------------//

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

        //--------------------------------------------------------------------------------------//
    }
}
