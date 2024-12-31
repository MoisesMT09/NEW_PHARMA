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

        public void Incluir(ModeloCategoria modelo)
        {
            try
            {
                // Configuração do comando
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao; // Garantir que a conexão foi inicializada
                    cmd.CommandText = "INSERT INTO Categoria (Nome) VALUES (@Nome); SELECT SCOPE_IDENTITY();";

                    // Configurando o parâmetro explicitamente
                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = modelo.CategNome;

                    // Abrindo conexão com tratamento adequado
                    conexao.AbrirConexao();

                    // Executando o comando e verificando o resultado
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        modelo.CategID = id; // Armazena o ID gerado
                    }
                    else
                    {
                        throw new Exception("Não foi possível obter o ID gerado.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log ou tratamento de erro
                Console.WriteLine($"Erro ao inserir na tabela Categoria: {ex.Message}");
            }
            finally
            {
                // Fechar a conexão de forma segura
                conexao.FecharConexao();
            }

        }

        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "UPDATE tbCategoria SET Nome = @Nome WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@Nome", modelo.CategNome);
            cmd.Parameters.AddWithValue("@ID", modelo.CategID);
            conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            conexao.FecharConexao();
        }

        public void Excluir(int Codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "DELETE FROM tbCategoria WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", Codigo);
            conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            conexao.FecharConexao();
        }

        public DataTable Localizar(String valor)
        {
            System.Data.DataTable tabela = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbCategoria WHERE Nome LIKE '%" + valor + "%'", selectConnectionString: conexao.StringConexao1);
            da.Fill(tabela);
            return tabela;

        }

        public ModeloCategoria CarregaModeloCategoria(int Codigo)
        {

            ModeloCategoria modelo = null; // Inicializa o modelo como nulo

            try
            {
                // Definindo o comando SQL
                string query = "SELECT * FROM tbCategoria WHERE ID = @ID";

                // Abrindo a conexão
                using (SqlConnection conexao = new SqlConnection(DConexao.StringConexao))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        // Adicionando o parâmetro com tipo explícito
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Codigo;

                        // Abrindo a conexão
                        conexao.Open();

                        // Executando a consulta
                        using (SqlDataReader registro = cmd.ExecuteReader())
                        {
                            // Verifica se há registros
                            if (registro.HasRows)
                            {
                                registro.Read(); // Lê a primeira linha do resultado

                                // Inicializa o modelo e atribui os valores
                                modelo = new ModeloCategoria
                                {
                                    CategID = Convert.ToInt32(registro["ID"]),
                                    CategNome = Convert.ToString(registro["Nome"])
                                };
                            }
                            else
                            {
                                // Caso não encontre dados, você pode decidir o que fazer (opcional)
                                Console.WriteLine("Nenhuma categoria encontrada.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar os dados da categoria.");
            }

            return modelo; // Retorna o modelo com os dados ou nulo caso não tenha encontrado
        }

    }
 
}
