using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Modelo;

namespace Negocio
{
    public class NegProduto
    {
        private DadosConexao conexao;

        public NegProduto(DadosConexao cox)
        {
            this.conexao = cox;
        }
        
    }
}
