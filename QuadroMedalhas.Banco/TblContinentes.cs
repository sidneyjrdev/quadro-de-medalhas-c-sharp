using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuadroMedalhas.Banco
{
    public class TblContinentes
    {
        public int id { get; set; }
        public string nome { get; set; }

        public DataTable selecionarComboBox()
        {
            try
            { 
                SqlCommand comando = new SqlCommand();
                comando.Connection = QuadroMedalhas.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "SELECT * FROM Continentes ORDER BY nome";
                DataTable dt = new DataTable();
                dt.Load(comando.ExecuteReader());
                return dt;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao obter continentes. Descrição: " + ex.Message.ToString());
                return null;
            }
        }

        
    }
}
