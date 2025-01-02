using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()
        {
            this.ClienteID = 0;
            this.NomeCliente = "";
            this.NumBICliente = "";
            this.EnderecoCliente = "";
            this.TelefoneCliente = "";
        }

        public ModeloCliente(int clienteID, string nomeCliente, string numBICliente, string enderecoCliente, string telefoneCliente)
        {
            this.ClienteID = clienteID;
            this.NomeCliente = nomeCliente;
            this.NumBICliente = numBICliente;
            this.EnderecoCliente = enderecoCliente;
            this.TelefoneCliente = telefoneCliente;
        }

        public int ClienteID { get; set; }
        public string NomeCliente { get; set; }
        public string NumBICliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string TelefoneCliente { get; set; }
    }
}





