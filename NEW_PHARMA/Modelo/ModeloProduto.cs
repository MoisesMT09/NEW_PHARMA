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
        NomeProduto = string.Empty;
        DescProduto = string.Empty;
        QuantEstProduto = 0;
        PrecoProduto = 0m;
        CategID = 0;
        FornecID = 0;
    }

    public ModeloProduto(int produtoID,string nomeProduto, string descProduto, int quantEstProduto, decimal precoProduto, DateTime dataValida, int categID, int fornecID)
    {
        ID = produtoID;
        NomeProduto = nomeProduto;
        DescProduto = descProduto;
        QuantEstProduto = quantEstProduto;
        PrecoProduto = precoProduto;
        DataValida = dataValida;
        CategID = categID;
        FornecID = fornecID;
    }

    public int ID { get; set; }
    public string NomeProduto { get; set; }
    public string DescProduto { get; set; }
    public int QuantEstProduto { get; set; }
    public decimal PrecoProduto { get; set; }
    public DateTime? DataValida { get; set; } = new DateTime(2025, 1, 1);
    public int CategID { get; set; }
    public int FornecID { get; set; }

}
