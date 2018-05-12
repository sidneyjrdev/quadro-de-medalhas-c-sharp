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
    public class TblPaises
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }
        public int ouro { get; set; }
        public int prata { get; set; }
        public int bronze { get; set; }
        public int id_continente { get; set; }
        public byte[] bandeira { get; set; }

        public DataTable SelecionarGrid()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                DataTable dt = new DataTable();
                comando.Connection = QuadroMedalhas.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "SELECT bandeira, p.id AS id, sigla, p.nome AS nome, c.nome AS continente, ouro, prata, bronze, (ouro+prata+bronze) AS total, id_continente FROM Paises p INNER JOIN Continentes c ON p.id_continente = c.id ORDER BY ouro DESC, prata DESC, bronze DESC";
                dt.Load(comando.ExecuteReader());
                return dt;

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao obter os países. Descrição: " + ex.Message.ToString());
                return null;
            }
        }

        public DataTable SelecionarTudo()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                DataTable dt = new DataTable();
                comando.Connection = QuadroMedalhas.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "SELECT * FROM Paises";
                dt.Load(comando.ExecuteReader());
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os países. Descrição: " + ex.Message.ToString());
                return null;
            }
        }

        public void Inserir()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = QuadroMedalhas.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "INSERT INTO Paises VALUES(@nome, @sigla, @ouro, @prata, @bronze, @id_continente, @bandeira)";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@sigla", sigla);
                comando.Parameters.AddWithValue("@ouro", ouro);
                comando.Parameters.AddWithValue("@prata", prata);
                comando.Parameters.AddWithValue("@bronze", bronze);
                comando.Parameters.AddWithValue("@id_continente", id_continente);
                comando.Parameters.AddWithValue("@bandeira", bandeira);
                comando.ExecuteNonQuery();

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao inserir país. Descrição: " + ex.Message.ToString());
            }
        }

        public void Alterar()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = QuadroMedalhas.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "UPDATE Paises SET nome = @nome, sigla = @sigla, ouro = @ouro, prata = @prata, bronze = @bronze, id_continente = @id_continente, bandeira = @bandeira WHERE id = @id";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@sigla", sigla);
                comando.Parameters.AddWithValue("@ouro", ouro);
                comando.Parameters.AddWithValue("@prata", prata);
                comando.Parameters.AddWithValue("@bronze", bronze);
                comando.Parameters.AddWithValue("@id_continente", id_continente);
                comando.Parameters.AddWithValue("@bandeira", bandeira);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar país. Descrição: " + ex.Message.ToString());
            }
        }

        public void Excluir()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = QuadroMedalhas.Utilitarios.ConexaoBanco.conexao;

                comando.CommandText = "DELETE FROM Paises WHERE id = @id";
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir país. Descrição: " + ex.Message.ToString());
            }
        }
    }
}
