using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FornecedorDAL: ConnectionToSql
    {
        // Método para inserir um fornecedor
        public void InserirFornecedor(string nome, string telefone, string endereco, string nif)
        {
            string query = @"INSERT INTO Fornecedores (Nome, Telefone, Endereco, NIF)
                             VALUES (@Nome, @Telefone, @Endereco, @NIF)";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Endereco", endereco);
                cmd.Parameters.AddWithValue("@NIF", nif);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para listar todos os fornecedores
        public DataTable ListarFornecedores()
        {
            string query = "SELECT * FROM Fornecedores";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        // Método para atualizar um fornecedor existente
        public void AtualizarFornecedor(int fornecedorId, string nome, string telefone, string endereco, string nif)
        {
            string query = @"UPDATE Fornecedores
                             SET Nome = @Nome, Telefone = @Telefone, Endereco = @Endereco, NIF = @NIF
                             WHERE FornecedorID = @FornecedorID";

            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FornecedorID", fornecedorId);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Endereco", endereco);
                cmd.Parameters.AddWithValue("@NIF", nif);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para deletar um fornecedor
        public void DeletarFornecedor(int fornecedorId)
        {
            string query = "DELETE FROM Fornecedores WHERE FornecedorID = @FornecedorID";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FornecedorID", fornecedorId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para buscar fornecedor por nome
        public DataTable BuscarFornecedorPorNome(string nome)
        {
            string query = "SELECT * FROM Fornecedores WHERE Nome LIKE @Nome";
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

        // Método para buscar fornecedor por NIF
        public DataTable BuscarFornecedorPorNIF(string nif)
        {
            string query = "SELECT * FROM Fornecedores WHERE NIF = @NIF";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NIF", nif);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
