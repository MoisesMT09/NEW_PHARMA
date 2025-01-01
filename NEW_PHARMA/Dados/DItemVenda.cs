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
    public class DItemVenda
    {
        private DadosConexao conexao;

        public DItemVenda(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloItemVenda modelo)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conexao.ObjectoConexao;
                    cmd.CommandText = "INSERT INTO tbItem_Venda (VendaID, ProdutoID, Quantidade, Preco_Unitario) " +
                                      "VALUES (@VendaID, @ProdutoID, @Quantidade, @PrecoUnitario); SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@VendaID", modelo.VendaID);
                    cmd.Parameters.AddWithValue("@ProdutoID", modelo.ProdutoID);
                    cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
                    cmd.Parameters.AddWithValue("@PrecoUnitario", modelo.PrecoUnitario);

                    conexao.AbrirConexao();
                    modelo.ItemVendaID = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Alterar(ModeloItemVenda modelo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "UPDATE tbItem_Venda SET VendaID = @VendaID, ProdutoID = @ProdutoID, Quantidade = @Quantidade, Preco_Unitario = @PrecoUnitario " +
                                  "WHERE ID = @ID";

                cmd.Parameters.AddWithValue("@VendaID", modelo.VendaID);
                cmd.Parameters.AddWithValue("@ProdutoID", modelo.ProdutoID);
                cmd.Parameters.AddWithValue("@Quantidade", modelo.Quantidade);
                cmd.Parameters.AddWithValue("@PrecoUnitario", modelo.PrecoUnitario);
                cmd.Parameters.AddWithValue("@ID", modelo.ItemVendaID);

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
                cmd.CommandText = "DELETE FROM tbItem_Venda WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", id);

                conexao.AbrirConexao();
                cmd.ExecuteNonQuery();
            }
            conexao.FecharConexao();
        }

        public DataTable LocalizarPorVenda(int vendaID)
        {
            DataTable tabela = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbItem_Venda WHERE VendaID = " + vendaID, conexao.StringConexao1))
            {
                da.Fill(tabela);
            }
            return tabela;
        }

        public ModeloItemVenda CarregaModeloItemVenda(int id)
        {
            ModeloItemVenda modelo = null;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexao.ObjectoConexao;
                cmd.CommandText = "SELECT * FROM tbItem_Venda WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", id);

                conexao.AbrirConexao();
                using (SqlDataReader registro = cmd.ExecuteReader())
                {
                    if (registro.HasRows)
                    {
                        registro.Read();
                        modelo = new ModeloItemVenda
                        {
                            ItemVendaID = Convert.ToInt32(registro["ID"]),
                            VendaID = Convert.ToInt32(registro["VendaID"]),
                            ProdutoID = Convert.ToInt32(registro["ProdutoID"]),
                            Quantidade = Convert.ToInt32(registro["Quantidade"]),
                            PrecoUnitario = Convert.ToDecimal(registro["Preco_Unitario"])
                        };
                    }
                }
            }
            conexao.FecharConexao();
            return modelo;
        }
    }
}
