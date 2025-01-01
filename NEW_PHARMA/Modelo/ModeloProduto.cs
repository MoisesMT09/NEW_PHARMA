using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

public class ModeloProduto
{
    public ModeloProduto()
    {
        ProdutoID = 0;
        CategID = 0;
        NomeProduto = string.Empty;
        DescProduto = string.Empty;
        QuantEstProduto = 0;
        PrecoProduto = 0m;
        FornecID = 0;
    }

    public ModeloProduto(int produtoID, int categID, string nomeProduto, string descProduto, int quantEstProduto, decimal precoProduto, int fornecID)
    {
        ProdutoID = produtoID;
        CategID = categID;
        NomeProduto = nomeProduto;
        DescProduto = descProduto;
        QuantEstProduto = quantEstProduto;
        PrecoProduto = precoProduto;
        FornecID = fornecID;
    }

    public int ProdutoID { get; set; }
    public int CategID { get; set; }
    public string NomeProduto { get; set; }
    public string DescProduto { get; set; }
    public int QuantEstProduto { get; set; }
    public decimal PrecoProduto { get; set; }
    public int FornecID { get; set; }
}
