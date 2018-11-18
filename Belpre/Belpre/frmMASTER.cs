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
        private Criptografia cripto = new Criptografia();

        //-----------------------------------------------MAIN------------------------------------------------//

        public frmMASTER()
        {
            InitializeComponent();
        }

        //---------------------------------------TAB CONTROL-------------------------------------------//

        private void tabAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se a selecionada é a consulta
            if (tabAdmin.SelectedTab.Name == "tabConsulta")
            {
                LoadMedicos();
            }
        }

        //-----------------------------------------------HOME-----------------------------------------------//

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo sair do modo de Administrador?", "Belpre",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();

                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        //---------------------------------------CADASTRAR----------------------------------------------------//

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
                sql = "INSERT INTO medicos VALUES" +
                    "(DEFAULT, @1, @2, @3, @4, @5, @6, @7, 'FALSE');";

                conexao.Run(sql, param);

                MessageBox.Show("Cadastro efetuado com sucesso!\n" + "Bem-vindo a Belpre, " + txtNomeCad.Text + "!",
                    "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpaCampos();
            }
            catch(Exception ex)
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

        //---------------------------------------CONSULTA MEDICOS-------------------------------------------//

        private void chkAtivos_CheckedChanged(object sender, EventArgs e)
        {
            LoadMedicos();
        }

        private void chkExcluidos_CheckedChanged(object sender, EventArgs e)
        {
            LoadMedicos();
        }

        private void LoadMedicos()
        {
            string sql="";

            bool vai = true;

            dgvConsulta.DataSource = null;

            try
            {
                if (chkAtivos.Checked && chkExcluidos.Checked)
                    sql = "SELECT id_med, nome, sobrenome, cpf" +
                    " FROM medicos" +
                    " ORDER BY id_med";
                else if (!chkAtivos.Checked && chkExcluidos.Checked)
                    sql = "SELECT id_med, nome, sobrenome, cpf" +
                    " FROM medicos" +
                    " WHERE excluido='True'" +
                    " ORDER BY id_med";
                else if (chkAtivos.Checked && !chkExcluidos.Checked)
                    sql = "SELECT id_med, nome, sobrenome, cpf" +
                    " FROM medicos" +
                    " WHERE excluido='False'" +
                    " ORDER BY id_med";
                else
                    vai = false;

                if (vai)
                {
                    DataSet ds = new DataSet();
                    ds = conexao.SelectDataSet(sql);

                    //Carregar o grid com os dados do DatSet
                    dgvConsulta.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvConsulta_DoubleClick(object sender, EventArgs e)
        {
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
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            LoadMedicos();
        }

        //--------------------------------------------ALTERAÇÃO MEDICOS----------------------------------------------//

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
                        if (dr["excluido"].ToString() == "False")
                        {
                            if (radFemAlt.Checked)
                                btnEstado.Text = "&Excluir Médica";
                            else
                                btnEstado.Text = "&Excluir Médico";
                        }
                        else
                        {
                            if (radFemAlt.Checked)
                                btnEstado.Text = "&Reativar Médica";
                            else
                                btnEstado.Text = "&Reativar Médico";
                        }
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

                mskCPFAlt.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
        }

        private void btnLimpaAlt_Click(object sender, EventArgs e)
        {
            LimpaCamposAlt();
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
            try
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

                int tam = txtSenhaAlt.Text.Length;

                //Campo SENHA
                if (!String.IsNullOrWhiteSpace(txtSenhaAlt.Text) && tam != 32)
                    param.Add(cripto.RetornarMD5(txtSenhaAlt.Text));
                else if (!String.IsNullOrWhiteSpace(txtSenhaAlt.Text) && tam == 32)
                    param.Add(txtSenhaAlt.Text);
                else
                {
                    ErroPreenchimento();
                    return;
                }

                mskCPFAlt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    param.Add(Convert.ToInt64(mskCPFAlt.Text));
                mskCPFAlt.TextMaskFormat = MaskFormat.IncludeLiterals;

                //Salva no banco de dados
                sql = "UPDATE medicos SET " +
                        "nome=@1, " +
                        "sobrenome=@2, " +
                        "sexo=@3, " +
                        "data_nascm=@4, " +
                        "celular=@5, " +
                        "senha=@6 " +
                            "WHERE cpf=@7";

                conexao.Run(sql, param);

                MessageBox.Show("Usuário alterado com sucesso!\n", "Belpre", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpaCamposAlt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!\nMais informações: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            try
            {
                List<object> param = new List<object>();
                string op, sql;

                if (btnEstado.Text == "&Excluir Médica" || btnEstado.Text == "&Excluir Médico")
                    op = "excluir";
                else
                    op = "reativar";

                DialogResult resp = MessageBox.Show("Deseja realmente " + op + " " + txtNomeAlt.Text + "?", "Belpre",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    //O estado do paciente
                    if (op == "excluir")
                        param.Add(true);
                    else
                        param.Add(false);

                    //pega o cpf
                    mskCPFAlt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        param.Add(Convert.ToInt64(mskCPFAlt.Text));
                    mskCPFAlt.TextMaskFormat = MaskFormat.IncludeLiterals;

                    sql = "UPDATE medicos SET " +
                            "excluido=@1 " +
                            "WHERE cpf=@2";

                    conexao.Run(sql, param);

                    MessageBox.Show("Usuário alterado com sucesso!\n", "Belpre",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpaCamposAlt();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!\nMais informações: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
