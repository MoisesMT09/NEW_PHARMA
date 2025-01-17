using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Modelo;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dados
{
    public class DProduto
    {
        private DadosConexao conexao;

        public DProduto(DadosConexao conexao)
        {
            this.conexao = conexao;
        }

        public bool CategoriaExiste(int categID)
        {
            string query = "SELECT COUNT(*) FROM Categoria WHERE CategID = @CategID";
            using (SqlConnection conn = new SqlConnection(conexao.StringConexao1))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategID", categID);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool FornecedorExiste(int fornecID)
        {
            string query = "SELECT COUNT(*) FROM Fornecedor WHERE FornecID = @FornecID";
            using (SqlConnection conn = new SqlConnection(conexao.StringConexao1))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FornecID", fornecID);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        public void InserirProduto(ModeloProduto produto)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = @"
                        INSERT INTO tbProduto 
                        (Nome, Descricao, Quant_Estoque, Preco, DataValidade, CategoriaID, FornecedorID) 
                        VALUES 
                        (@Nome, @Descricao, @QuantEstoque, @Preco, @DataValidade, @CategoriaID, @FornecedorID); 
                        SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = produto.NomeProduto;
                    cmd.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = produto.DescProduto;
                    cmd.Parameters.Add("@QuantEstoque", SqlDbType.Int).Value = produto.QuantEstProduto;
                    cmd.Parameters.Add("@Preco", SqlDbType.Decimal).Value = produto.PrecoProduto;
                    cmd.Parameters.Add("@DataValidade", SqlDbType.Date).Value = produto.DataValida;
                    cmd.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = produto.CategID;
                    cmd.Parameters.Add("@FornecedorID", SqlDbType.Int).Value = produto.FornecID;

                    conexao.AbrirConexao();
                    produto.ID = Convert.ToInt32(cmd.ExecuteScalar()); // Obtém o ID gerado pelo banco
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Produto: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public bool Alterar(ModeloProduto produto)
        {
            try
            {
                string sql = @"
                    UPDATE tbProduto
                    SET Nome = @Nome,
                        Descricao = @Descricao,
                        Quant_Estoque = @QuantEstoque,
                        Preco = @Preco,
                        DataValidade = @DataValidade,
                        CategoriaID = @CategoriaID,
                        FornecedorID = @FornecedorID
                    WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(sql, conexao.ObjectoConexao))
                {
                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = produto.NomeProduto;
                    cmd.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = produto.DescProduto;
                    cmd.Parameters.Add("@QuantEstoque", SqlDbType.Int).Value = produto.QuantEstProduto;
                    cmd.Parameters.Add("@Preco", SqlDbType.Decimal).Value = produto.PrecoProduto;
                    cmd.Parameters.Add("@DataValidade", SqlDbType.Date).Value = produto.DataValida;
                    cmd.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = produto.CategID;
                    cmd.Parameters.Add("@FornecedorID", SqlDbType.Int).Value = produto.FornecID;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = produto.ID;

                    conexao.AbrirConexao();
                    return cmd.ExecuteNonQuery() > 0; // Retorna true se houver linhas afetadas
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar Produto: " + ex.Message);
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
                    cmd.CommandText = "DELETE FROM tbProduto WHERE ID = @ID";
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    conexao.AbrirConexao();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("Nenhum produto encontrado com o ID fornecido.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Produto: " + ex.Message);
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
                string query = string.IsNullOrEmpty(valor)
                    ? "SELECT * FROM tbProduto"
                    : "SELECT * FROM tbProduto WHERE Nome LIKE @Valor";

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
                throw new Exception("Erro ao localizar Produto: " + ex.Message);
            }
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int id)
        {
            try
            {
                string query = "SELECT * FROM tbProduto WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conexao.ObjectoConexao))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    conexao.AbrirConexao();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ModeloProduto
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                NomeProduto = Convert.ToString(reader["Nome"]),
                                DescProduto = Convert.ToString(reader["Descricao"]),
                                QuantEstProduto = Convert.ToInt32(reader["Quant_Estoque"]),
                                PrecoProduto = Convert.ToDecimal(reader["Preco"]),
                                DataValida = Convert.ToDateTime(reader["DataValidade"]),
                                CategID = Convert.ToInt32(reader["CategoriaID"]),
                                FornecID = Convert.ToInt32(reader["FornecedorID"])
                            };
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar dados do Produto: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    }
}
