using Microsoft.Data.SqlClient;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class DCategoria
    {
        private DadosConexao conexao;

        public DCategoria(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "INSERT INTO Categoria (Nome) VALUES (@nome); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@Nome", modelo.CategNome);
            conexao.AbrirConexao();
            modelo.CategID = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.FecharConexao();
        }

        public void Alterar(ModeloCategoria modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "UPDATE tbCategoria SET Nome = @nome WHERE ID = @id";
            cmd.Parameters.AddWithValue("@Nome", modelo.CategNome);
            cmd.Parameters.AddWithValue("@ID", modelo.CategID);
            conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            conexao.FecharConexao();
        }

        public void Excluir(int Codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjectoConexao;
            cmd.CommandText = "DELETE FROM tbCategoria WHERE ID = @id";
            cmd.Parameters.AddWithValue("@ID", Codigo);
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
            cmd.CommandText = "SELECT * FROM tbCategoria WHERE ID = @ID";
            cmd.Parameters.AddWithValue("@ID", Codigo);
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
