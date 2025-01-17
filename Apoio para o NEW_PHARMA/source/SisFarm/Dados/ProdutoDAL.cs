using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ProdutoDAL : ConnectionToSql
    {
        // Método para inserir um produto
        public void InserirProduto(string nome, int categoriaId, string descricao, decimal preco, DateTime dataValidade, int estoque, string status, int fornecedorId)
        {
            string query = @"INSERT INTO Produtos (Nome, CategoriaID, Descricao, Preco, DataValidade, Estoque, Status, FornecedorID)
                             VALUES (@Nome, @CategoriaID, @Descricao, @Preco, @DataValidade, @Estoque, @Status, @FornecedorID)";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaId);
                cmd.Parameters.AddWithValue("@Descricao", descricao);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.Parameters.AddWithValue("@DataValidade", dataValidade);
                cmd.Parameters.AddWithValue("@Estoque", estoque);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@FornecedorID", fornecedorId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable BuscarProdutoPorID(int produtoId)
        {
            string query = "SELECT * FROM Produtos WHERE ProdutoID = @ProdutoID";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        // Método para listar todos os produtos
        public DataTable ListarProdutos()
        {
            string query = "SELECT p.ProdutoID, p.Nome, p.Descricao, p.Preco, p.Estoque, p.Status, p.DataValidade, c.Nome AS Categoria, f.Nome AS Fornecedor " +
               "FROM Produtos p " +
               "JOIN Categorias c ON p.CategoriaID = c.CategoriaID " +
               "JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID " +
               "ORDER BY p.ProdutoID DESC";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Método para atualizar um produto existente
        public void AtualizarProduto(int produtoId, string nome, int categoriaId, string descricao, decimal preco, DateTime prazo, int estoque, string status, int fornecedorId)
        {
            string query = @"UPDATE Produtos
                             SET Nome = @Nome, CategoriaID = @CategoriaID, Descricao = @Descricao, 
                                 Preco = @Preco, DataValidade = @DataValidade, Estoque = @Estoque, Status = @Status, FornecedorID = @FornecedorID
                             WHERE ProdutoID = @ProdutoID";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaId);
                cmd.Parameters.AddWithValue("@Descricao", descricao);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.Parameters.AddWithValue("@DataValidade", prazo);
                cmd.Parameters.AddWithValue("@Estoque", estoque);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@FornecedorID", fornecedorId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para deletar um produto
        public void DeletarProduto(int produtoId)
        {
            string query = "DELETE FROM Produtos WHERE ProdutoID = @ProdutoID";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProdutoID", produtoId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Métodos para realizar as diferentes buscas.
        public DataTable BuscarPorNome(string nome)
        {
            string query = "SELECT p.ProdutoID, p.Nome, p.Descricao, p.Preco, p.Estoque, p.Status, p.DataValidade, " +
               "c.Nome AS Categoria, f.Nome AS Fornecedor " +
               "FROM Produtos p " +
               "JOIN Categorias c ON p.CategoriaID = c.CategoriaID " +
               "JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID " +
               "WHERE p.Nome LIKE @Nome " +
               "ORDER BY p.ProdutoID DESC";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nome", $"%{nome}%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable BuscarPorStatus(string status)
        {
            string query;

            if (status == "Todos os status")
            {
                query = @"SELECT p.ProdutoID, 
                         p.Nome, 
                         p.Descricao, 
                         p.Preco, 
                         p.Estoque, 
                         p.Status, 
                         p.DataValidade, 
                         c.Nome AS Categoria, 
                         f.Nome AS Fornecedor
                  FROM Produtos p
                  JOIN Categorias c ON p.CategoriaID = c.CategoriaID
                  JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID
                  ORDER BY p.ProdutoID DESC";
            }
            else
            {
                query = @"SELECT p.ProdutoID, 
                         p.Nome, 
                         p.Descricao, 
                         p.Preco, 
                         p.Estoque, 
                         p.Status, 
                         p.DataValidade, 
                         c.Nome AS Categoria, 
                         f.Nome AS Fornecedor
                  FROM Produtos p
                  JOIN Categorias c ON p.CategoriaID = c.CategoriaID
                  JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID
                  WHERE p.Status = @Status
                  ORDER BY p.ProdutoID DESC";
            }

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                if (status != "Todos os status")
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                return table;
            }
        }

        public DataTable BuscarPorEstoque(string tipoEstoque)
        {
            string query;

            if (tipoEstoque == "Em Estoque")
            {
                query = "SELECT p.ProdutoID, p.Nome, p.Descricao, p.Preco, p.Estoque, p.Status, p.DataValidade, c.Nome AS Categoria, f.Nome AS Fornecedor " +
                        "FROM Produtos p " +
                        "JOIN Categorias c ON p.CategoriaID = c.CategoriaID " +
                        "JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID " +
                        "WHERE p.Estoque > 0 " +
                        "ORDER BY p.ProdutoID DESC";
            }
            else if (tipoEstoque == "Sem Estoque")
            {
                query = "SELECT p.ProdutoID, p.Nome, p.Descricao, p.Preco, p.Estoque, p.Status, p.DataValidade, c.Nome AS Categoria, f.Nome AS Fornecedor " +
                        "FROM Produtos p " +
                        "JOIN Categorias c ON p.CategoriaID = c.CategoriaID " +
                        "JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID " +
                        "WHERE p.Estoque = 0 " +
                        "ORDER BY p.ProdutoID DESC";
            }
            else if (tipoEstoque == "Estoque Baixo")
            {
                query = "SELECT p.ProdutoID, p.Nome, p.Descricao, p.Preco, p.Estoque, p.Status, p.DataValidade, c.Nome AS Categoria, f.Nome AS Fornecedor " +
                        "FROM Produtos p " +
                        "JOIN Categorias c ON p.CategoriaID = c.CategoriaID " +
                        "JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID " +
                        "WHERE p.Estoque BETWEEN 1 AND 10 " +
                        "ORDER BY p.ProdutoID DESC";
            }
            else if (tipoEstoque == "Todos os Estoques")
            {
                query = "SELECT p.ProdutoID, p.Nome, p.Descricao, p.Preco, p.Estoque, p.Status, p.DataValidade, c.Nome AS Categoria, f.Nome AS Fornecedor " +
                        "FROM Produtos p " +
                        "JOIN Categorias c ON p.CategoriaID = c.CategoriaID " +
                        "JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID " +
                        "ORDER BY p.ProdutoID DESC";
            }
            else
            {
                // Caso o tipoEstoque não seja reconhecido, podemos lançar uma exceção ou atribuir uma consulta padrão
                throw new ArgumentException("Tipo de estoque inválido.");
            }


            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable BuscarPorCategoria(int categoriaId)
        {
            string query = "SELECT p.ProdutoID, p.Nome, p.Descricao, p.Preco, p.Estoque, p.Status, p.DataValidade, c.Nome AS Categoria, f.Nome AS Fornecedor " +
                           "FROM Produtos p " +
                           "JOIN Categorias c ON p.CategoriaID = c.CategoriaID " +
                           "JOIN Fornecedores f ON p.FornecedorID = f.FornecedorID " +
                           "WHERE p.CategoriaID = @CategoriaID " +
                           "ORDER BY p.ProdutoID DESC";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Buscar produtos por Fornecedor
        public DataTable BuscarPorFornecedor(int fornecedorId)
        {
            string query = "SELECT * FROM Produtos WHERE FornecedorID = @FornecedorID";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FornecedorID", fornecedorId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
