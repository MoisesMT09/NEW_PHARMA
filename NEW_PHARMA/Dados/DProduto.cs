using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Modelo;
using Dados;

namespace Dados
{
    public class DProduto
    {
        private DadosConexao conexao;

        public DProduto(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void InserirProduto(ModeloProduto produto)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "INSERT INTO tbProduto (CategoriaID, Nome, Descricao, QuantEstoque, Preco, FornecedorID) " +
                                      "VALUES (@CategoriaID, @Nome, @Descricao, @QuantEstoque, @Preco, @FornecedorID); " +
                                      "SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = produto.CategID;
                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = produto.NomeProduto;
                    cmd.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = produto.DescProduto;
                    cmd.Parameters.Add("@QuantEstoque", SqlDbType.Int).Value = produto.QuantEstProduto;
                    cmd.Parameters.Add("@Preco", SqlDbType.Decimal).Value = produto.PrecoProduto;
                    cmd.Parameters.Add("@FornecedorID", SqlDbType.Int).Value = produto.FornecID;

                    conexao.AbrirConexao();
                    produto.ProdutoID = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ModeloProduto produto)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "UPDATE tbProduto " +
                                      "SET CategoriaID = @CategoriaID, " +
                                      "    Nome = @Nome, " +
                                      "    Descricao = @Descricao, " +
                                      "    QuantEstoque = @QuantEstoque, " +
                                      "    Preco = @Preco, " +
                                      "    FornecedorID = @FornecedorID " +
                                      "WHERE ProdutoID = @ProdutoID";

                    // Adiciona os parâmetros com tipos explícitos
                    cmd.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = produto.CategID;
                    cmd.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = produto.NomeProduto;
                    cmd.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = produto.DescProduto;
                    cmd.Parameters.Add("@QuantEstoque", SqlDbType.Int).Value = produto.QuantEstProduto;
                    cmd.Parameters.Add("@Preco", SqlDbType.Decimal).Value = produto.PrecoProduto;
                    cmd.Parameters.Add("@FornecedorID", SqlDbType.Int).Value = produto.FornecID;
                    cmd.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = produto.ProdutoID;

                    // Abre a conexão, executa o comando e fecha automaticamente
                    conexao.AbrirConexao();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Trata exceções e propaga o erro
                throw new Exception("Erro ao alterar produto: " + ex.Message);
            }
            finally
            {
                // Garante o fechamento da conexão
                conexao.FecharConexao();
            }
        }


        public void Excluir(int produtoID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "DELETE FROM tbProduto WHERE ProdutoID = @ProdutoID";

                    // Adiciona o parâmetro com tipo explícito
                    cmd.Parameters.Add("@ProdutoID", SqlDbType.Int).Value = produtoID;

                    // Abre a conexão, executa o comando e fecha automaticamente
                    conexao.AbrirConexao();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Trata exceções e propaga o erro
                throw new Exception("Erro ao excluir produto: " + ex.Message);
            }
            finally
            {
                // Garante o fechamento da conexão
                conexao.FecharConexao();
            }
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "SELECT * FROM tbProduto WHERE Nome LIKE @Valor";

                    // Define o parâmetro com o tipo apropriado
                    cmd.Parameters.Add("@Valor", SqlDbType.NVarChar).Value = $"%{valor}%";

                    // Usa SqlDataAdapter para preencher a tabela
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabela);
                    }
                }
            }
            catch (Exception ex)
            {
                // Trata exceções
                throw new Exception("Erro ao localizar produtos: " + ex.Message);
            }

            return tabela;
        }


        public ModeloProduto CarregaModeloProduto(int Codigo)
        {
            ModeloProduto modelo = null;

            try
            {
                string query = "SELECT * FROM tbProduto WHERE ID = @ID";
                using (SqlConnection conexao = new SqlConnection(DConexao.StringConexao))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conexao))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Codigo;

                        conexao.Open();
                        using (SqlDataReader registro = cmd.ExecuteReader())
                        {
                            if (registro.HasRows)
                            {
                                registro.Read();

                                modelo = new ModeloProduto
                                {
                                    ProdutoID = Convert.ToInt32(registro["ID"]),
                                    CategID = Convert.ToInt32(registro["CategoriaID"]),
                                    NomeProduto = Convert.ToString(registro["Nome"]),
                                    DescProduto = Convert.ToString(registro["Descricao"]),
                                    QuantEstProduto = Convert.ToInt32(registro["QuantEstoque"]),
                                    PrecoProduto = Convert.ToDecimal(registro["Preco"]),
                                    FornecID = Convert.ToInt32(registro["FornecedorID"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar os dados do produto.", ex);
            }

            return modelo;
        }

    }


}

