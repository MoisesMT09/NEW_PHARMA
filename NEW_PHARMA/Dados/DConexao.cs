using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class DConexao
    {
        public static String StringConexao
        {
            get
            {
                return "Data Source=GHDSE-PC8\\MSSQLSERVERT;Initial Catalog=dbNEW_PHARMA;Integrated Security=True;Trust Server Certificate=True";
            }
        }
    }
}
