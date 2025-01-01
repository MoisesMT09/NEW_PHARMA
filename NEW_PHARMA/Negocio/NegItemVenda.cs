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
    public class NegItemVenda
    {
        private DadosConexao conexao;

        public NegItemVenda(DadosConexao cox)
        {
            this.conexao = cox;
        }

        public void Incluir(ModeloItemVenda modelo)
        {
            if (modelo.VendaID <= 0)
                throw new Exception("O código da venda é obrigatório.");
            if (modelo.ProdutoID <= 0)
                throw new Exception("O código do produto é obrigatório.");
            if (modelo.Quantidade <= 0)
                throw new Exception("A quantidade deve ser maior que zero.");
            if (modelo.PrecoUnitario <= 0)
                throw new Exception("O preço unitário deve ser maior que zero.");

            DItemVenda Dobj = new DItemVenda(conexao);
            Dobj.Incluir(modelo);
        }

        public void Alterar(ModeloItemVenda modelo)
        {
            if (modelo.ItemVendaID <= 0)
                throw new Exception("O código do item da venda é obrigatório.");
            if (modelo.VendaID <= 0)
                throw new Exception("O código da venda é obrigatório.");
            if (modelo.ProdutoID <= 0)
                throw new Exception("O código do produto é obrigatório.");
            if (modelo.Quantidade <= 0)
                throw new Exception("A quantidade deve ser maior que zero.");
            if (modelo.PrecoUnitario <= 0)
                throw new Exception("O preço unitário deve ser maior que zero.");

            DItemVenda Dobj = new DItemVenda(conexao);
            Dobj.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            if (id <= 0)
                throw new Exception("O código do item da venda é obrigatório.");

            DItemVenda Dobj = new DItemVenda(conexao);
            Dobj.Excluir(id);
        }

        public DataTable LocalizarPorVenda(int vendaID)
        {
            DItemVenda Dobj = new DItemVenda(conexao);
            return Dobj.LocalizarPorVenda(vendaID);
        }

        public ModeloItemVenda CarregaModeloItemVenda(int id)
        {
            DItemVenda Dobj = new DItemVenda(conexao);
            return Dobj.CarregaModeloItemVenda(id);
        }
    }
}
