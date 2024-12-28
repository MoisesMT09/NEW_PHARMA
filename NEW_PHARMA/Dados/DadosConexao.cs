using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Dados
{
    internal class DadosConexao
    {
        private String StringConexao;
        private SqlConnection Conexao;

        public DadosConexao(String dadosConexao)
        {
            this.Conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this.Conexao.ConnectionString = dadosConexao;
        }
        public String StringConexao1
        {
            get { return this.StringConexao1; }
            set { this.StringConexao1 = value; }
        }

        public SqlConnection ObjectoConexao
        {
            get { return this.Conexao; }
            set { this.Conexao = value; }
        }

        public void AbrirConexao()
        {
                this.Conexao.Open();
        }

        public void FecharConexao()
        {
            this.Conexao.Close();
        }
    }
}
