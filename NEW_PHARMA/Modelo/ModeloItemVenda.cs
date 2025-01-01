using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItemVenda
    {
        public ModeloItemVenda()
        {
            this.ItemVendaID = 0;
            this.VendaID = 0;
            this.ProdutoID = 0;
            this.Quantidade = 0;
            this.PrecoUnitario = 0;
        }

        public ModeloItemVenda(int itemVendaID, int vendaID, int produtoID, int quantidade, decimal precoUnitario)
        {
            this.ItemVendaID = itemVendaID;
            this.VendaID = vendaID;
            this.ProdutoID = produtoID;
            this.Quantidade = quantidade;
            this.PrecoUnitario = precoUnitario;
        }

        private int itemVendaID;
        public int ItemVendaID
        {
            get { return itemVendaID; }
            set { itemVendaID = value; }
        }

        private int vendaID;
        public int VendaID
        {
            get { return vendaID; }
            set { vendaID = value; }
        }

        private int produtoID;
        public int ProdutoID
        {
            get { return produtoID; }
            set { produtoID = value; }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private decimal precoUnitario;
        public decimal PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }
    }
}
