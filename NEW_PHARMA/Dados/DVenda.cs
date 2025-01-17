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
    public class DVenda
    {
        private DadosConexao conexao;

        public DVenda(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloVenda modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "INSERT INTO tbVenda (DATA, ClienteID, ProdutoID, Quantidade, Valor_Total, FuncionarioID) " +
                                      "VALUES (@DATA, @ClienteID, @ProdutoID, @Quantidade, @ValorTotal, @FuncionarioID); " +
                                      "SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@DATA", modelo.DataVenda);
                    cmd.Parameters.AddWithValue("@ClienteID", modelo.ClienteID);
                    cmd.Parameters.AddWithValue("@ProdutoID", modelo.ProdutoID);
                    cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
                    cmd.Parameters.AddWithValue("@ValorTotal", modelo.ValorTotal);

                    conexao.AbrirConexao();
                    modelo.VendaID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Alterar(ModeloVenda modelo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "UPDATE tbVenda SET DATA = @DATA, ClienteID = @ClienteID, ProdutoID = @ProdutoID, " +
                                  "Quantidade = @Quantidade, Valor_Total = @ValorTotal, FuncionarioID = @FuncionarioID " +
                                  "WHERE ID = @ID";

                cmd.Parameters.AddWithValue("@DATA", modelo.DataVenda);
                cmd.Parameters.AddWithValue("@ClienteID", modelo.ClienteID);
                cmd.Parameters.AddWithValue("@ProdutoID", modelo.ProdutoID);
                cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
                cmd.Parameters.AddWithValue("@ValorTotal", modelo.ValorTotal);
                cmd.Parameters.AddWithValue("@ID", modelo.VendaID);

                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
            }
            conexao.FecharConexao();
        }

        public void Excluir(int ID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "DELETE FROM tbVenda WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", ID);

                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
            }
            conexao.FecharConexao();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbVenda WHERE DATA LIKE '%" + valor + "%'", conexao.StringConexao1))
            {
                da.Fill(tabela);
            }
            return tabela;
        }

        public ModeloVenda CarregaModeloVenda(int ID)
        {
            ModeloVenda? modelo = null;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "SELECT * FROM tbVenda WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", ID);

                conexao.AbrirConexao();
                using (SqlDataReader registro = cmd.ExecuteReader())
                {
                    if (registro.HasRows)
                    {
                        registro.Read();
                        modelo = new ModeloVenda
                        {
                            VendaID = Convert.ToInt32(registro["ID"]),
                            DataVenda = Convert.ToDateTime(registro["DATA"]),
                            ClienteID = Convert.ToInt32(registro["ClienteID"]),
                            ProdutoID = Convert.ToInt32(registro["ProdutoID"]),
                            Quantidade = Convert.ToInt32(registro["Quantidade"]),
                            ValorTotal = Convert.ToDecimal(registro["Valor_Total"]),
                        };
                    }
                }
            }
            conexao.FecharConexao();
            return modelo;
        }
    }
}
