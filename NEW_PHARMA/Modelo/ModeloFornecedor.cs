using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Modelo
{
    public class ModeloFornecedor
    {
        public ModeloFornecedor()
        {
            this.FornecedorID = 0;
            this.NomeFornecedor = "";
            this.NIFFornecedor = "";
            this.EnderecoFornecedor = "";
            this.TelefoneFornecedor = "";
            this.EmailFornecedor = "";
        }

        public ModeloFornecedor(int fornecedorID, string nomeFornecedor, string nifFornecedor, string enderecoFornecedor, string telefoneFornecedor, string emailFornecedor)
        {
            this.FornecedorID = fornecedorID;
            this.NomeFornecedor = nomeFornecedor;
            this.NIFFornecedor = nifFornecedor;
            this.EnderecoFornecedor = enderecoFornecedor;
            this.TelefoneFornecedor = telefoneFornecedor;
            this.EmailFornecedor = emailFornecedor;
        }

        public int FornecedorID { get; set; }
        public string NomeFornecedor { get; set; }
        public string NIFFornecedor { get; set; }
        public string EnderecoFornecedor { get; set; }
        public string TelefoneFornecedor { get; set; }
        public string EmailFornecedor { get; set; }
    }
}
