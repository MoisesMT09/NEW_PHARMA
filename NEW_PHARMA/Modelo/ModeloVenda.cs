using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Modelo
{
    public class ModeloVenda
    {
        public ModeloVenda()
        {
            this.VendaID = 0;
            this.DataVenda = DateTime.Now;
            this.ClienteID = 0;
            this.ProdutoID = 0;
            this.Quantidade = 0;
            this.ValorTotal = 0;
            this.FuncionarioID = 0;
        }

        public ModeloVenda(int id, DateTime data, int clienteId, int produtoId, int quantidade, decimal valorTotal, int funcionarioId)
        {
            this.VendaID = id;
            this.DataVenda = data;
            this.ClienteID = clienteId;
            this.ProdutoID = produtoId;
            this.Quantidade = quantidade;
            this.ValorTotal = valorTotal;
            this.FuncionarioID = funcionarioId;
        }

        private int id;
        public int VendaID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime dataVenda;
        public DateTime DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }

        private int clienteId;
        public int ClienteID
        {
            get { return clienteId; }
            set { clienteId = value; }
        }

        private int produtoId;
        public int ProdutoID
        {
            get { return produtoId; }
            set { produtoId = value; }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private decimal valorTotal;
        public decimal ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        private int funcionarioId;
        public int FuncionarioID
        {
            get { return funcionarioId; }
            set { funcionarioId = value; }
        }
    }
}
