using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.DTO
{
    public class Login
    {
        public string _Login { get; set; }

        public string Senha { get; set; }

        public void ValidarAcesso(Login login)
        {
            if (string.IsNullOrEmpty(login._Login) || string.IsNullOrEmpty(login.Senha))
                throw new ArgumentException("Realizar o preenchimento dos campos obrigatórios.");
        }
    }
}
