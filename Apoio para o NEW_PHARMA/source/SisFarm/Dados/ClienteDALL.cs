using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ClienteDALL: ConnectionToSql
    {
        // Inserir Cliente
        public void InserirCliente(string nome, string telefone, string endereco)
        {
            string query = @"INSERT INTO Clientes (Nome, Telefone, Endereco) 
                             VALUES (@Nome, @Telefone, @Endereco)";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Endereco", endereco);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Listar Clientes
        public DataTable ListarClientes()
        {
            string query = "SELECT * FROM Clientes";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Atualizar Cliente
        public void AtualizarCliente(int clienteId, string nome, string telefone, string endereco)
        {
            string query = @"UPDATE Clientes 
                             SET Nome = @Nome, Telefone = @Telefone, Endereco = @Endereco 
                             WHERE ClienteID = @ClienteID";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ClienteID", clienteId);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Endereco", endereco);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Deletar Cliente
        public void DeletarCliente(int clienteId)
        {
            string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ClienteID", clienteId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
