using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class VendaDAL: ConnectionToSql
    {
        // Método para registrar uma venda
        public int RegistrarVenda(int clienteId, decimal total, string status)
        {
            // Corrigido: Agora inclui Status
            string query = @"INSERT INTO Vendas (ClienteID, Total, Status)
                     VALUES (@ClienteID, @Total, @Status);
                     SELECT SCOPE_IDENTITY();"; // Retorna o ID da venda criada

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ClienteID", clienteId);
                cmd.Parameters.AddWithValue("@Total", total);
                cmd.Parameters.AddWithValue("@Status", status); // Adicionando status

                connection.Open();
                // Retorna o ID da venda criada
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


        // Método para registrar detalhes de uma venda
        public void RegistrarDetalhesVenda(int vendaId, int produtoId, int quantidade, decimal precoUnitario, decimal totalItem)
        {
            string query = @"INSERT INTO DetalhesVendas (VendaID, ProdutoID, Quantidade, PrecoUnitario, TotalItem)
                     VALUES (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @TotalItem)";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                cmd.Parameters.AddWithValue("@ProdutoID", produtoId);
                cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                cmd.Parameters.AddWithValue("@PrecoUnitario", precoUnitario);
                cmd.Parameters.AddWithValue("@TotalItem", totalItem);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }


        // Método para listar todas as vendas
        public DataTable ListarVendas()
        {
            string query = @"SELECT V.VendaID, V.DataVenda, V.ClienteID, C.Nome AS ClienteNome, 
                                    V.Total, V.Status
                             FROM Vendas V
                             INNER JOIN Clientes C ON V.ClienteID = C.ClienteID";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Método para listar detalhes de uma venda
        public DataTable ListarDetalhesVenda(int vendaId)
        {
            string query = @"SELECT DV.DetalheID, DV.VendaID, DV.ProdutoID, P.Nome AS ProdutoNome,
                                    DV.Quantidade, DV.PrecoUnitario, DV.TotalItem
                             FROM DetalhesVenda DV
                             INNER JOIN Produtos P ON DV.ProdutoID = P.ProdutoID
                             WHERE DV.VendaID = @VendaID";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@VendaID", vendaId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Método para buscar vendas por cliente
        public DataTable BuscarVendasPorCliente(int clienteId)
        {
            string query = @"SELECT V.VendaID, V.DataVenda, V.ClienteID, C.Nome AS ClienteNome, 
                                    V.Total, V.Status
                             FROM Vendas V
                             INNER JOIN Clientes C ON V.ClienteID = C.ClienteID
                             WHERE V.ClienteID = @ClienteID";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ClienteID", clienteId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
