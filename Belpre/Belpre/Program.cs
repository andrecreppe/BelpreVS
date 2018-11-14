using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belpre
{
    static class Program
    {
        public static Connection conexao;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Server CTI*/
//            conexao = new Connection("200.145.153.175", "5432", "1_72A_AULAS_2018", "alunocti", "alunocti");
            /*Localhost - André's home*/
           conexao = new Connection("localhost", "5432", "Belpre", "postgres", "060802");
            /*Localhost - LDI*/
//            conexao = new Connection("localhost", "5432", "Belpre", "postgres", "sqladmin");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//          Application.Run(new frmLogin());
                Application.Run(new frmMedico("Debugger", "m", 1));
        }
    }
}
