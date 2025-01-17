using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class DConexao
    {
        public static String StringConexao
        {
            get
            {
                return "Data Source=GHDSE-PC8\\MSSQLSERVERT;Initial Catalog=NEW_PHARMA;Integrated Security=True;Trust Server Certificate=True";
            }

        }
    

        private DadosConexao conexao;

        // Construtor da classe DConexao
        public DConexao()
        {
            // Inicializa a conexão com a string de conexão
            conexao = new DadosConexao(StringConexao);
        }
    }
}
