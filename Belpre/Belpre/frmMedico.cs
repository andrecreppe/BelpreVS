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
    using FluentDateTime;
    using Npgsql;
    using static Belpre.Program;

namespace Belpre
{
    public partial class frmMedico : Form
    {
        private string logado, sexo;

        private int index_agenda = 0;

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

        //----------------------------------------------------------------------------------

        private void tabMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMedico.SelectedIndex == 1) //Agenda
            {
                index_agenda = 0;
                UpdateDateAgenda(index_agenda);
            }
        }

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
    }
}
