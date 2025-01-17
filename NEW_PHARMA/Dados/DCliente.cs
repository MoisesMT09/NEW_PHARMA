using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Modelo;

namespace Dados
{
    public class DCliente
    {
        private readonly DadosConexao conexao;

        public DCliente(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloCliente modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "INSERT INTO tbCliente (Nome, Endereco, Telefone) " +
                                      "VALUES (@Nome, @Endereco, @Telefone); SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = modelo.NomeCliente;
                    cmd.Parameters.Add("@Endereco", SqlDbType.NVarChar).Value = modelo.EnderecoCliente;
                    cmd.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = modelo.TelefoneCliente;

                    conexao.AbrirConexao();
                    int idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                    modelo.DefinirID(idGerado); // Define o ID gerado no modelo.
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.ID <= 0)
            {
                throw new ArgumentException("O ID deve ser maior que zero para alterar um cliente.");
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "UPDATE tbCliente SET Nome = @Nome, Endereco = @Endereco, Telefone = @Telefone " +
                                      "WHERE ID = @ID";

                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = modelo.NomeCliente;
                    cmd.Parameters.Add("@Endereco", SqlDbType.NVarChar).Value = modelo.EnderecoCliente;
                    cmd.Parameters.Add("@Telefone", SqlDbType.NVarChar).Value = modelo.TelefoneCliente;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = modelo.ID;

                    conexao.AbrirConexao();
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Nenhum cliente encontrado para o ID fornecido.");
                    }
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Excluir(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("O ID deve ser maior que zero para excluir um cliente.");
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "DELETE FROM tbCliente WHERE ID = @ID";

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    conexao.AbrirConexao();
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Nenhum cliente encontrado para o ID fornecido.");
                    }
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            string query = string.IsNullOrEmpty(valor)
                ? "SELECT * FROM tbCliente"
                : "SELECT * FROM tbCliente WHERE Nome LIKE @Valor";

            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, conexao.StringConexao1))
                {
                    if (!string.IsNullOrEmpty(valor))
                    {
                        da.SelectCommand.Parameters.Add("@Valor", SqlDbType.NVarChar).Value = $"%{valor}%";
                    }

                    da.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao localizar cliente: {ex.Message}");
            }

            return tabela;
        }

        public ModeloCliente CarregarModeloCliente(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("O ID deve ser maior que zero para carregar um cliente.");
            }

            ModeloCliente modelo = null;

            try
            {
                string query = "SELECT * FROM tbCliente WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conexao.ObjectoConexao))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    conexao.AbrirConexao();

                    using (SqlDataReader registro = cmd.ExecuteReader())
                    {
                        if (registro.Read())
                        {
                            modelo = new ModeloCliente
                            {
                                //ID = Convert.ToInt32(registro["ID"]),
                                NomeCliente = registro["Nome"].ToString(),
                                EnderecoCliente = registro["Endereco"].ToString(),
                                TelefoneCliente = registro["Telefone"].ToString()
                            };
                        }
                        else
                        {
                            throw new Exception("Cliente não encontrado.");
                        }
                    }
                }
            }
            finally
            {
                conexao.FecharConexao();
            }

            return modelo;
        }

        public DataTable CarregarClientes()
        {
            DataTable tabela = new DataTable();
            string query = "SELECT * FROM tbCliente";

            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(query, conexao.StringConexao1))
                {
                    da.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar clientes: {ex.Message}");
            }

            return tabela;
        }

        public int ObterUltimoID()
        {
            try
            {
                string query = "SELECT MAX(ID) AS UltimoID FROM tbCliente";

                using (SqlCommand cmd = new SqlCommand(query, conexao.ObjectoConexao))
                {
                    conexao.AbrirConexao();
                    object resultado = cmd.ExecuteScalar();
                    return resultado != DBNull.Value ? Convert.ToInt32(resultado) : 0;
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

    }
}
