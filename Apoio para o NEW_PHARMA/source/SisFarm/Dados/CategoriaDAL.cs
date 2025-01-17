using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CategoriaDAL: ConnectionToSql
    {

        public void InserirCategoria(string nome)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO Categoria (Nome) VALUES (@Nome)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", nome);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT CategoriaID, Nome FROM Categorias";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categorias.Add(new Categoria
                    {
                        CategoriaID = reader.GetInt32(0),
                        Nome = reader.GetString(1)
                    });
                }
            }

            return categorias;
        }

        public void AtualizarCategoria(int categoriaID, string nome)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE Categoria SET Nome = @Nome WHERE CategoriaID = @CategoriaID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);
                cmd.Parameters.AddWithValue("@Nome", nome);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletarCategoria(int categoriaID)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM Categoria WHERE CategoriaID = @CategoriaID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Classe Categoria (representa a tabela Categoria no banco de dados)
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nome { get; set; }
    }
}
