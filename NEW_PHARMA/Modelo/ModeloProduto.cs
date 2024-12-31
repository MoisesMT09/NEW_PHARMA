using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public ModeloProduto() 
        {
            this.ProdutoID = 0;
            this.CategID = 0;
            this.NomeProduto = "";
            this.DescProduto = "";
            this.QuantEstProduto = 0;
            this.PrecoProduto = 0;
            this.FornecID = 0;
        }
        public ModeloProduto(int ProdutoID, int CategID, String NomeProduto, String DescProduto, int QuantEstProduto, decimal PrecoProduto, int FornecID)
        {
            this.ProdutoID = ID;
            this.CategID = ID;
            this.NomeProduto = Nome;
            this.DescProduto = Descricao;
            this.QuantEstProduto = QuantEstoque;
            this.PrecoProduto = Preco;
            this.FornecID = FornecedorID;
        }


        //ID INT IDENTITY(1,1) NOT NULL,
        private int ID;
        public int ProdutoID
        {
            get { return ID; }
            set { ID = value; }
        }

        //CategoriaID TINYINT,
        private int CategoriaID;
        public int CategID
        {
            get { return CategoriaID; }
            set { CategoriaID = value; }
        }

        //Nome VARCHAR(50) NOT NULL,
        private String Nome;
        public String NomeProduto
        {
            get { return Nome; }
            set { Nome = value; }

        }

        //Descricao VARCHAR(100),
        private String Descricao;
        public String DescProduto
        {
            get { return Descricao; }
            set { Descricao = value; }
        }

        //Quant_Estoque TINYINT,
        private int QuantEstoque;
        public int QuantEstProduto
        {
            get { return QuantEstoque; }
            set { QuantEstoque = value; }
        }

        //Preco DECIMAL NOT NULL,
        private Decimal Preco;
        public Decimal PrecoProduto
        {
            get { return Preco; }
            set { Preco = value; }
        }


        //FornecedorID TINYINT,
        private int FornecedorID;

        public int FornecID
        {
            get { return FornecedorID; }
            set { FornecedorID = value; }
        }


        //FOREIGN KEY(FornecedorID) REFERENCES tbFornecedor(ID),
        //FOREIGN KEY(CategoriaID) REFERENCES tbCategoria(ID),
        //PRIMARY KEY(ID)
        //);
    }
}
