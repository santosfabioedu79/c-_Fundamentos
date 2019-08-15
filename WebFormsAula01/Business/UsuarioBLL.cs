using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class UsuarioBLL
    {
        public usuarioModel UsuarioLogado
        {
            get
            {
                usuarioModel usr = new usuarioModel();
                usr.Login = "admin";
                usr.Nome = "Administrador";

                return usr;
            }
        }
        public bool Logar(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                return true;
            }
            return false;
        }
    }
}
