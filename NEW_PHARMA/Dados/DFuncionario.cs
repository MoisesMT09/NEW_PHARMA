using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Modelo;
using System.Data;

namespace Dados
{
    public class DFuncionario
    {
        private DadosConexao conexao;

        public DFuncionario(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloFuncionario modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "INSERT INTO tbFuncionario (Nome, N_BI, Email, Endereco, Telefone) " +
                                      "VALUES (@Nome, @N_BI, @Email, @Endereco, @Telefone); SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@Nome", modelo.NomeFuncionario);
                    cmd.Parameters.AddWithValue("@N_BI", modelo.NumBI);
                    cmd.Parameters.AddWithValue("@Email", modelo.EmailFuncionario);
                    cmd.Parameters.AddWithValue("@Endereco", modelo.EnderecoFuncionario);
                    cmd.Parameters.AddWithValue("@Telefone", modelo.TelefoneFuncionario);

                    conexao.AbrirConexao();
                    modelo.FuncionarioID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Alterar(ModeloFuncionario modelo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "UPDATE tbFuncionario SET Nome = @Nome, N_BI = @N_BI, Email = @Email, Endereco = @Endereco, Telefone = @Telefone " +
                                  "WHERE ID = @ID";

                cmd.Parameters.AddWithValue("@Nome", modelo.NomeFuncionario);
                cmd.Parameters.AddWithValue("@N_BI", modelo.NumBI);
                cmd.Parameters.AddWithValue("@Email", modelo.EmailFuncionario);
                cmd.Parameters.AddWithValue("@Endereco", modelo.EnderecoFuncionario);
                cmd.Parameters.AddWithValue("@Telefone", modelo.TelefoneFuncionario);
                cmd.Parameters.AddWithValue("@ID", modelo.FuncionarioID);

                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
            }
            conexao.FecharConexao();
        }

        public void Excluir(int id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "DELETE FROM tbFuncionario WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", id);

                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
            }
            conexao.FecharConexao();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbFuncionario WHERE Nome LIKE '%" + valor + "%'", conexao.StringConexao1))
            {
                da.Fill(tabela);
            }
            return tabela;
        }

        public ModeloFuncionario CarregaModeloFuncionario(int id)
        {
            ModeloFuncionario modelo = null;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "SELECT * FROM tbFuncionario WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", id);

                conexao.AbrirConexao();
                using (SqlDataReader registro = cmd.ExecuteReader())
                {
                    if (registro.HasRows)
                    {
                        registro.Read();
                        modelo = new ModeloFuncionario
                        {
                            FuncionarioID = Convert.ToInt32(registro["ID"]),
                            NomeFuncionario = Convert.ToString(registro["Nome"]),
                            NumBI = Convert.ToString(registro["N_BI"]),
                            EmailFuncionario = Convert.ToString(registro["Email"]),
                            EnderecoFuncionario = Convert.ToString(registro["Endereco"]),
                            TelefoneFuncionario = Convert.ToString(registro["Telefone"])
                        };
                    }
                }
            }
            conexao.FecharConexao();
            return modelo;
        }
    }
}
