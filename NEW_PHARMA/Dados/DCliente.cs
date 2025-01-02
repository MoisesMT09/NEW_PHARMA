using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Modelo;

namespace Dados
{
    public class DCliente
    {
        private DadosConexao conexao;

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
                    cmd.CommandText = "INSERT INTO tbCliente (Nome, N_BI, Endereco, Telefone) " +
                                      "VALUES (@Nome, @NBI, @Endereco, @Telefone); SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@Nome", modelo.NomeCliente);
                    cmd.Parameters.AddWithValue("@NBI", modelo.NumBICliente);
                    cmd.Parameters.AddWithValue("@Endereco", modelo.EnderecoCliente);
                    cmd.Parameters.AddWithValue("@Telefone", modelo.TelefoneCliente);

                    conexao.AbrirConexao();
                    modelo.ClienteID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Alterar(ModeloCliente modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                { 
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "UPDATE tbCliente SET Nome = @Nome, N_BI = @NBI, Endereco = @Endereco, Telefone = @Telefone " +
                                      "WHERE ID = @ID";

                    cmd.Parameters.AddWithValue("@Nome", modelo.NomeCliente);
                    cmd.Parameters.AddWithValue("@NBI", modelo.NumBICliente);
                    cmd.Parameters.AddWithValue("@Endereco", modelo.EnderecoCliente);
                    cmd.Parameters.AddWithValue("@Telefone", modelo.TelefoneCliente);
                    cmd.Parameters.AddWithValue("@ID", modelo.ClienteID);

                    conexao.AbrirConexao();
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Excluir(int id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "DELETE FROM tbCliente WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);

                    conexao.AbrirConexao();
                    cmd.ExecuteNonQuery();
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
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand
                    {
                        Connection = conexao.ObjectoConexao,
                        CommandText = "SELECT ID, Nome, N_BI, Endereco, Telefone " +
                                      "FROM tbCliente WHERE Nome LIKE @Valor OR N_BI LIKE @Valor"
                    };
                    da.SelectCommand.Parameters.AddWithValue("@Valor", "%" + valor + "%");

                    da.Fill(tabela);
                }
            }
            catch
            {
                throw new Exception("Erro ao buscar clientes.");
            }
            return tabela;
        }

        public ModeloCliente CarregarModeloCliente(int id)
        {
            ModeloCliente modelo = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "SELECT ID, Nome, N_BI, Endereco, Telefone FROM tbCliente WHERE ID = @ID";
                    cmd.Parameters.AddWithValue("@ID", id);

                    conexao.AbrirConexao();
                    using (SqlDataReader registro = cmd.ExecuteReader())
                    {
                        if (registro.HasRows)
                        {
                            registro.Read();
                            modelo = new ModeloCliente
                            {
                                ClienteID = Convert.ToInt32(registro["ID"]),
                                NomeCliente = registro["Nome"].ToString(),
                                NumBICliente = registro["N_BI"].ToString(),
                                EnderecoCliente = registro["Endereco"].ToString(),
                                TelefoneCliente = registro["Telefone"].ToString()
                            };
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
    }
}
