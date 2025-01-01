using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Modelo;

namespace Dados
{
    public class DFornecedor
    {
        private DadosConexao conexao;

        public DFornecedor(DadosConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "INSERT INTO tbFornecedor (Nome, NIF, Endereco, Telefone, E_mail) " +
                                  "VALUES (@Nome, @NIF, @Endereco, @Telefone, @Email); SELECT SCOPE_IDENTITY();";

                cmd.Parameters.AddWithValue("@Nome", modelo.NomeFornecedor);
                cmd.Parameters.AddWithValue("@NIF", modelo.NIFFornecedor);
                cmd.Parameters.AddWithValue("@Endereco", modelo.EnderecoFornecedor);
                cmd.Parameters.AddWithValue("@Telefone", modelo.TelefoneFornecedor);
                cmd.Parameters.AddWithValue("@Email", modelo.EmailFornecedor);

                conexao.AbrirConexao();
                modelo.FornecedorID = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.FecharConexao();
            }
        }

        public void Alterar(ModeloFornecedor modelo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "UPDATE tbFornecedor SET Nome = @Nome, NIF = @NIF, Endereco = @Endereco, " +
                                  "Telefone = @Telefone, E_mail = @Email WHERE ID = @ID";

                cmd.Parameters.AddWithValue("@Nome", modelo.NomeFornecedor);
                cmd.Parameters.AddWithValue("@NIF", modelo.NIFFornecedor);
                cmd.Parameters.AddWithValue("@Endereco", modelo.EnderecoFornecedor);
                cmd.Parameters.AddWithValue("@Telefone", modelo.TelefoneFornecedor);
                cmd.Parameters.AddWithValue("@Email", modelo.EmailFornecedor);
                cmd.Parameters.AddWithValue("@ID", modelo.FornecedorID);

                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
            }
        }

        public void Excluir(int id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "DELETE FROM tbFornecedor WHERE ID = @ID";

                cmd.Parameters.AddWithValue("@ID", id);

                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();
            }
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM tbFornecedor WHERE Nome LIKE '%{valor}%';", conexao.StringConexao1))
            {
                da.Fill(tabela);
            }
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int id)
        {
            ModeloFornecedor modelo = null;
            string query = "SELECT * FROM tbFornecedor WHERE ID = @ID";

            using (SqlConnection con = new SqlConnection(conexao.StringConexao1))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                using (SqlDataReader registro = cmd.ExecuteReader())
                {
                    if (registro.HasRows)
                    {
                        registro.Read();
                        modelo = new ModeloFornecedor
                        {
                            FornecedorID = Convert.ToInt32(registro["ID"]),
                            NomeFornecedor = registro["Nome"].ToString(),
                            NIFFornecedor = registro["NIF"].ToString(),
                            EnderecoFornecedor = registro["Endereco"].ToString(),
                            TelefoneFornecedor = registro["Telefone"].ToString(),
                            EmailFornecedor = registro["E_mail"].ToString()
                        };
                    }
                }
            }
            return modelo;
        }
    }
}

