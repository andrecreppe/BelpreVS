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
    public partial class frmPacientes : Form
    {
        private int id_pac;

        //--------------------------------------MAIN-----------------------------------//

        public frmPacientes(int id)
        {
            InitializeComponent();

            id_pac = id;

            //Data de hoje
            lblHoje.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Dados paciente
            CarregaInfo();

            //Dados consultas
            CarregaConsultas();
        }

        //--------------------------------------HOME-----------------------------------//

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult resp;

            if (lblSexo.Text == "Masculino")
                resp = MessageBox.Show("Deseja mesmo sair Sr. " + lblNome.Text + "?", "Belpre",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                resp = MessageBox.Show("Deseja mesmo sair Sra. " + lblNome.Text + "?", "Belpre",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();

                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        //------------------------------------MEUS DADOS-----------------------------------//

        private void btnErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por-favor contate seu médico para que ele possa corrigir seus dados!",
                "Belpre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //------------------------------------FUNCTIONS-----------------------------------//
        
        private void CarregaInfo()
        {
            string sql, cpf, tel;

            try
            {
                //Consultas hoje
                sql = "SELECT COUNT(id_cons) FROM consultas " +
                    "WHERE id_pac=" + id_pac + " " +
                    "AND data_cons='" + DateTime.Now.ToString("dd-MM-yyyy") + "'";

                NpgsqlDataReader dr = conexao.Select(sql);

                if(dr.Read())
                {
                    int cons = Convert.ToInt32(dr["count"]);

                    if(cons <= 1)
                        lblConsultas.Text = cons.ToString() + " consulta!";
                    else
                        lblConsultas.Text = cons.ToString() + " consultas!";
                }

                dr.Close();

                //Info do Paciente
                sql = "SELECT * FROM pacientes " +
                    "WHERE id_pac=" + id_pac;

                dr = conexao.Select(sql);

                if (dr.Read())
                {
                    lblNome.Text = dr["nome"].ToString();
                    lblSobre.Text = dr["sobrenome"].ToString();
                    lblNascm.Text = dr["data_nascm"].ToString();

                    if (dr["sexo"].ToString() == "M")
                    {
                        lblSexo.Text = "Masculino";
                        lblBemVindo.Text = "Bem-vindo " + lblNome.Text;
                        picPaciente.Image = Image.FromFile(@"Images\pac_m.png");
                    }   
                    else
                    {
                        lblSexo.Text = "Feminino";
                        lblBemVindo.Text = "Bem-vinda " + lblNome.Text;
                        picPaciente.Image = Image.FromFile(@"Images\pac_f.png");
                    }
                    
                    cpf = dr["cpf"].ToString();
                    cpf = cpf.Insert(3, ".");
                    cpf = cpf.Insert(7, ".");
                    cpf = cpf.Insert(11, "-");
                        lblCPF.Text = cpf;
                    tel = dr["celular"].ToString();
                    tel = tel.Insert(2, " ");
                    tel = tel.Insert(8, "-");
                        lblTell.Text = tel;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaConsultas()
        {
            grpConsultaNO.Hide();
            grpRetornoNO.Hide();

            string sql, unicode, id_med="";
            int cons=0, ret=0;

            NpgsqlDataReader dr;

            try
            {
                //Consultas
                sql = "SELECT COUNT(id_cons) FROM consultas" +
                    " WHERE id_pac=" + id_pac +
                    " AND tipo='Consulta'" +
                    " AND data_cons>='" + DateTime.Now.ToString("dd-MM-yyyy") + "'";

                dr = conexao.Select(sql);
                if(dr.Read())
                {
                    cons = Convert.ToInt32(dr["count"]);
                    lblQtdCons.Text = cons + " agendado";
                }
                dr.Close();

                //Retornos
                sql = "SELECT COUNT(id_cons) FROM consultas" +
                    " WHERE id_pac=" + id_pac +
                    " AND tipo='Retorno'" +
                    " AND data_cons>='" + DateTime.Now.ToString("dd-MM-yyyy") + "'";

                dr = conexao.Select(sql);
                if (dr.Read())
                {
                    ret = Convert.ToInt32(dr["count"]);
                    lblQtdRet.Text = dr["count"].ToString() + " agendado";
                }
                dr.Close();

                // -----------

                if(cons > 0)
                {
                    //Consulta mais proxima
                    sql = "SELECT unicode, id_med FROM consultas" +
                        " WHERE id_pac=" + id_pac +
                        " AND data_cons>='" + DateTime.Now.ToString("dd-MM-yyyy") + "'" +
                        " AND tipo='Consulta'" +
                        " ORDER BY hora_cons LIMIT 1";

                    dr = conexao.Select(sql);
                    if (dr.Read())
                    {
                        unicode = dr["unicode"].ToString();
                            unicode = unicode.Insert(2, ":");
                            unicode = unicode.Insert(5, "h - ");
                            unicode = unicode.Insert(11, "/"); unicode = unicode.Insert(14, "/");
                        lblDataCons.Text = unicode;

                        id_med = dr["id_med"].ToString();
                    }
  
                    dr.Close();

                    sql = "SELECT nome FROM medicos WHERE id_med=" + id_med;

                    dr = conexao.Select(sql);

                    if(dr.Read())
                    {
                        lblMed1.Text = dr["nome"].ToString();
                    }

                    dr.Close();
                }
                else
                    grpConsultaNO.Show();

                if (ret > 0)
                {
                    //Retorno mais proximo
                    sql = "SELECT unicode FROM consultas" +
                        " WHERE id_pac=" + id_pac +
                        " AND data_cons>='" + DateTime.Now.ToString("dd-MM-yyyy") + "'" +
                        " AND tipo='Retorno'" +
                        " ORDER BY hora_cons LIMIT 1";

                    dr = conexao.Select(sql);
                    if (dr.Read())
                    {
                        unicode = dr["unicode"].ToString();
                            unicode = unicode.Insert(2, ":");
                            unicode = unicode.Insert(5, "h - ");
                            unicode = unicode.Insert(11, "/"); unicode = unicode.Insert(14, "/");
                        lblDataRet.Text = unicode;
                    }

                    dr.Close();

                    sql = "SELECT nome FROM medicos WHERE id_med=" + id_med;

                    dr = conexao.Select(sql);

                    if (dr.Read())
                    {
                        lblMed1.Text = dr["nome"].ToString();
                    }

                    dr.Close();
                }
                else
                    grpRetornoNO.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Programa!" + "\nMais Opções: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
