using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using QuadroMedalhas.Utilitarios;

namespace QuadroMedalhas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConexaoBanco.conexao= new SqlConnection(ConfigurationManager.ConnectionStrings["minhaConexao"].ConnectionString);
            ConexaoBanco.conexao.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmQuadro());
        }
    }
}
