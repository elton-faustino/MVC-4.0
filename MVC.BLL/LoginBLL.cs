using MVC.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.BLL
{
    public class LoginBLL
    {
        public void Logar(Login login)
        {
            var bd = new Login() { _Login = "elton", Senha = "123" };

            login.ValidarAcesso(login);

            if (!login.Senha.Equals(bd.Senha) && login._Login.Equals(bd._Login))
                throw new ArgumentException("Usuário e/ou senha inválidos.");
        }
    }
}
