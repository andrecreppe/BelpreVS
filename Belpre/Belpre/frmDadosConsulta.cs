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
    public partial class frmDadosConsulta : Form
    {
        private string unicode;

        //--------------------------------------------MAIN-------------------------------------------//
        public frmDadosConsulta(string selected_hora, string selected_data)
        {
            InitializeComponent();

            //Cria o unicode
            unicode = selected_hora + selected_data;
                unicode = unicode.Replace(":", string.Empty);
                unicode = unicode.Replace("h", string.Empty);
                unicode = unicode.Replace("-", string.Empty);

            //Coloca a data no label
            lblDia.Text = selected_data.Replace("-", "/") + " - " + selected_hora;

            CarregaDadosConsulta();
        }

        //-------------------------------------CARREGA OS DADOS----------------------------------------//

        public void CarregaDadosConsulta()
        {
            string sql = "SELECT id_pac, convenio, tipo FROM consultas " +
                "WHERE unicode='" + unicode +"'";

            try
            {
                NpgsqlDataReader dr = conexao.Select(sql);

                if (dr.Read())
                {
                    lblConsulta.Text = "(" + dr["convenio"].ToString() + ") " + dr["tipo"].ToString();

                    int id = Convert.ToInt32(dr["id_pac"]);
                    dr.Close();

                    CarregaDadosPaciente(id);
                }
                else
                {
                    dr.Close();
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!\nMais informações: " + ex.Message, "Belpre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaDadosPaciente(int id)
        {
            string sql, cpf, tel;
                
            sql = "SELECT nome, sobrenome, cpf, celular FROM pacientes " +
                "WHERE id_pac='" + id + "'";

            try
            {
                NpgsqlDataReader dr = conexao.Select(sql);

                if (dr.Read())
                {
                    lblPaciente.Text = dr["nome"].ToString() + " " + dr["sobrenome"].ToString();
                    cpf = "(" + dr["cpf"].ToString() + ")";
                        cpf = cpf.Insert(4, ".");
                        cpf = cpf.Insert(8, ".");
                        cpf = cpf.Insert(12, "-");
                        lblCPF.Text = cpf;
                    tel = "(" + dr["celular"].ToString() + ")";
                        tel = tel.Insert(3, " ");
                        tel = tel.Insert(9, "-");
                        lblContato.Text = tel;
                }
                else
                {
                    dr.Close();
                    throw new Exception();
                }

                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!\nMais informações: " + ex.Message, "Belpre",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
