using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {

        public ModeloCategoria() 
        {     
            this.CategNome = "";
        }

        public ModeloCategoria(int CategID, String CategNome)
        {
            this.CategID = ID;
            this.CategNome = Nome;
        }

        private int ID ;

        public int CategID
        {
            get { return ID; }
            set { ID = value; }
        }

        private String Nome = "";

        public String CategNome
        {
            get { return Nome; }
            set { Nome = value; }
        }
    }
}
