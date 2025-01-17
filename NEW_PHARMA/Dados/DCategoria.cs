using Microsoft.Data.SqlClient;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Dados
{
    public class DCategoria
    {
        private DadosConexao conexao;

        public DCategoria(DadosConexao cox)
        {
            this.conexao = cox;
        }

        // Método para incluir uma categoria
        public void Incluir(ModeloCategoria modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "INSERT INTO tbCategoria (Nome) VALUES (@Nome); SELECT SCOPE_IDENTITY();";

                    // Usando a variável CategNome do modelo para inserir no banco
                    cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = modelo.CategNome;

                    conexao.AbrirConexao();

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ID))
                    {
                        modelo.CategID = ID; // Armazena o ID gerado após a inserção
                    }
                    else
                    {
                        throw new Exception("Não foi possível obter o ID gerado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao inserir na tabela Categoria: {ex.Message}");
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        // Método para alterar uma categoria
        public void Alterar(ModeloCategoria modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "UPDATE tbCategoria SET Nome = @Nome WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@Nome", modelo.CategNome); // Usando CategNome
                    cmd.Parameters.AddWithValue("@ID", modelo.CategID); // Usando CategID

                    conexao.AbrirConexao();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao alterar categoria: {ex.Message}");
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        // Método para excluir uma categoria
        public void Excluir(int ID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "DELETE FROM tbCategoria WHERE ID = @ID";

                    // Adiciona o parâmetro com tipo explícito
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                    conexao.AbrirConexao();

                    // Exibe o ID sendo passado para depuração
                    Console.WriteLine($"Excluindo categoria com ID: {ID}");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Nenhuma categoria encontrada com o ID fornecido.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir categoria: {ex.Message}");
            }
            finally
            {
                conexao.FecharConexao();
            }
        }


        // Método para localizar categorias com base no nome
        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            try
            {
                string query = string.IsNullOrEmpty(valor)
                    ? "SELECT * FROM tbCategoria"
                    : "SELECT * FROM tbCategoria WHERE Nome LIKE @Valor";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conexao.StringConexao1))
                {
                    if (!string.IsNullOrEmpty(valor))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Valor", "%" + valor + "%");
                    }
                    da.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao localizar categoria: {ex.Message}");
            }
            return tabela;
        }

        // Método para carregar uma categoria por ID
        public ModeloCategoria CarregaModeloCategoria(int ID)
        {
            ModeloCategoria? modelo = null;
            try
            {
                string query = "SELECT * FROM tbCategoria WHERE ID = @ID";

                using (SqlConnection conn = new SqlConnection(conexao.StringConexao1))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                        conn.Open();
                        using (SqlDataReader registro = cmd.ExecuteReader())
                        {
                            if (registro.HasRows)
                            {
                                registro.Read();
                                modelo = new ModeloCategoria
                                {
                                    CategID = Convert.ToInt32(registro["ID"]), // Usando CategID
                                    CategNome = Convert.ToString(registro["Nome"]) // Usando CategNome
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar categoria: {ex.Message}");
            }
            return modelo;
        }

        public DataTable CarregarDados()
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexao.StringConexao1))
            {
                string sql = "SELECT * FROM tbCategoria"; // Ajuste os campos conforme sua tabela
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabela);
            }

            return tabela;
        }

    }
}
