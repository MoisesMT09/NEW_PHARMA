using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuarios
    {
        public class Usuario
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Login { get; set; }
            public string SenhaHash { get; set; }
            public int NivelAcesso { get; set; }
            public bool Ativo { get; set; }
        }

    }

    public enum NivelAcesso
    {
        Administrador = 1,
        Gestor = 2,
        Funcionario = 3
    }
}
