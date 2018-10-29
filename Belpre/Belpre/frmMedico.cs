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
        private string logado;

        public frmMedico(string recebido)
        {
            InitializeComponent();

            logado = recebido;
            label1.Text = logado;
        }
    }
}
