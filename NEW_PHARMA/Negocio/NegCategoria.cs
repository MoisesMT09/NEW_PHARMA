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
    internal class NegCategoria
    {
        private DadosConexao conexao;

        public NegCategoria(DadosConexao cox)
        {
            this.conexao = cox;
        }
        public void Incluir(ModeloCategoria modelo)
        {
            if(modelo.CategNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            DCategoria Dobj = new DCategoria(conexao);
            Dobj.Incluir(modelo);   
        }
        public void Alterar(ModeloCategoria modelo)
        {
            if(modelo.CategID <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }

            if (modelo.CategNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório");
            }
            DCategoria Dobj = new DCategoria(conexao);
            Dobj.Alterar(modelo);
        }
        public void Excluir(int Codigo)
        {
            DCategoria Dobj = new DCategoria(conexao);
            Dobj.Excluir(Codigo);
        }
        public DataTable Localizar(String valor)
        {
            DCategoria Dobj = new DCategoria(conexao);
            return Dobj.Localizar(valor);
        }
        public ModeloCategoria CarregaModeloCategoria(int Codigo)
        {
            DCategoria Dobj = new DCategoria(conexao);
            return Dobj.CarregaModeloCategoria(Codigo);
        }
    }
}
