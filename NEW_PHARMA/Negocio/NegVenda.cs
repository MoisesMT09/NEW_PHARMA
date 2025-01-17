using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using Dados;

namespace Negocio
{
    public class NegVenda
    {
        private DadosConexao conexao;

        public NegVenda(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloVenda modelo)
        {
            if (modelo.Quantidade <= 0)
                throw new Exception("A quantidade deve ser maior que zero.");
            if (modelo.ValorTotal <= 0)
                throw new Exception("O valor total deve ser maior que zero.");

            DVenda Dobj = new DVenda(conexao);
            Dobj.Incluir(modelo);
        }

        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VendaID <= 0)
                throw new Exception("O código da venda é obrigatório.");
            if (modelo.Quantidade <= 0)
                throw new Exception("A quantidade deve ser maior que zero.");
            if (modelo.ValorTotal <= 0)
                throw new Exception("O valor total deve ser maior que zero.");

            DVenda Dobj = new DVenda(conexao);
            Dobj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            if (id <= 0)
                throw new Exception("O código da venda é obrigatório.");

            DVenda Dobj = new DVenda(conexao);
            Dobj.Excluir(id);
        }

        public DataTable Localizar(string valor)
        {
            DVenda Dobj = new DVenda(conexao);
            return Dobj.Localizar(valor);
        }

        public ModeloVenda CarregaModeloVenda(int id)
        {
            DVenda Dobj = new DVenda(conexao);
            return Dobj.CarregaModeloVenda(id);
        }

        //public DataTable ObterTodosProdutos()
        //{
        //    DProduto dProduto = new DProduto(conexao);
        //    return dProduto.BuscarTodosProdutos();
        //}


    }
}

