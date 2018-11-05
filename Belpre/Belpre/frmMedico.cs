using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belpre
{
    public partial class frmMedico : Form
    {
        private string logado, sexo;

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
    }
}
