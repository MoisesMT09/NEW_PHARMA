using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class UserNegocio
    {
        UserDados UserDados = new UserDados();

        public bool LoginUser(string username, string password)
        {
            return UserDados.Login(username, password);
        }
    }
}
