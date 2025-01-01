using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
using Modelo;
using System;
using System.Data;

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

                    cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
                    cmd.Parameters.AddWithValue("@NBI", modelo.NBI);
                    cmd.Parameters.AddWithValue("@Endereco", modelo.Endereco);
                    cmd.Parameters.AddWithValue("@Telefone", modelo.Telefone);

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
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "UPDATE tbCliente SET Nome = @Nome, N_BI = @NBI, Endereco = @Endereco, Telefone = @Telefone " +
                                  "WHERE ID = @ID";

                cmd.Parameters.AddWithValue("@Nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@NBI", modelo.NBI);
                cmd.Parameters.AddWithValue("@Endereco", modelo.Endereco);
                cmd.Parameters.AddWithValue("@Telefone", modelo.Telefone);
                cmd.Parameters.AddWithValue("@ID", modelo.ClienteID);

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
                cmd.CommandText = "DELETE FROM tbCliente WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", id);

                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
            }
            conexao.FecharConexao();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbCliente WHERE Nome LIKE '%" + valor + "%'", conexao.StringConexao1))
            {
                da.Fill(tabela);
            }
            return tabela;
        }

        public ModeloCliente CarregaModeloCliente(int id)
        {
            ModeloCliente modelo = null;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "SELECT * FROM tbCliente WHERE ID = @ID";
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
                            Nome = Convert.ToString(registro["Nome"]),
                            NBI = Convert.ToString(registro["N_BI"]),
                            Endereco = Convert.ToString(registro["Endereco"]),
                            Telefone = Convert.ToString(registro["Telefone"])
                        };
                    }
                }
            }
            conexao.FecharConexao();
            return modelo;
        }
    }
}
