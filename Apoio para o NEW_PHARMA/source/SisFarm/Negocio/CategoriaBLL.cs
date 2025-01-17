using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaBLL
    {
        private CategoriaDAL categoriaDAL = new CategoriaDAL();

        public void InserirCategoria(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome da categoria é obrigatório.");
            }

            categoriaDAL.InserirCategoria(nome);
        }

        public List<Categoria> ListarCategorias()
        {
            return categoriaDAL.ListarCategorias();
        }

        public void AtualizarCategoria(int categoriaID, string nome)
        {
            if (categoriaID <= 0)
            {
                throw new ArgumentException("ID da categoria inválido.");
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome da categoria é obrigatório.");
            }

            categoriaDAL.AtualizarCategoria(categoriaID, nome);
        }

        public void DeletarCategoria(int categoriaID)
        {
            if (categoriaID <= 0)
            {
                throw new ArgumentException("ID da categoria inválido.");
            }

            categoriaDAL.DeletarCategoria(categoriaID);
        }
    }
}
