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

        public void Incluir(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "INSERT INTO tbProduto(CategoriaID, Nome, Descricao, QuantEstoque, Preco, FornecedorID ) VALUES (@CategoriaID@nome); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@CategoriaID", modelo.CategID);
            cmd.Parameters.AddWithValue("@Nome", modelo.NomeProduto);
            cmd.Parameters.AddWithValue("@Descricao", modelo.DescProduto);
            cmd.Parameters.AddWithValue("@QuantEstoque", modelo.QuantEstProduto);
            cmd.Parameters.AddWithValue("@Preco", modelo.PrecoProduto);
            cmd.Parameters.AddWithValue("@FornecedorID", modelo.FornecID);
            conexao.AbrirConexao();
            modelo.ProdutoID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.FecharConexao();
        }

        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "UPDATE tbCategoria SET Nome = @nome WHERE ID = @id";
            cmd.Parameters.AddWithValue("@nome", modelo.CategNome);
            cmd.Parameters.AddWithValue("@id", modelo.CategID);
            conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            conexao.FecharConexao();
        }

        public void Excluir(int Codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "DELETE FROM tbCategoria WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", Codigo);
            conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            conexao.FecharConexao();
        }

        public DataTable Localizar(String valor)
        {
            System.Data.DataTable tabela = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbCategoria WHERE Nome LIKE '%" + valor + "%'", conexao.StringConexao1);
            da.Fill(tabela);
            return tabela;

        }

        public ModeloCategoria CarregaModeloCategoria(int Codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "SELECT * FROM tbCategoria WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", Codigo);
            conexao.AbrirConexao();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CategID = Convert.ToInt32(registro["ID"]);
                modelo.CategNome = Convert.ToString(registro["Nome"]);
            }
            conexao.FecharConexao();
            return modelo;
        }

    }
}
