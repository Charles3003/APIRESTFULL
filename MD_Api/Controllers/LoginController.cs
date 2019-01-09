using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MD_Api.Controllers
{
    public class LoginController : ApiController
    {
        public Usuario Get(string pEmail, string pSenha)
        {
            Usuario oUsuario = new Usuario();
            oUsuario.Codigo = 1;
            oUsuario.Email = pEmail;
            oUsuario.Senha = pSenha;
            return oUsuario;
        }
    }

    public class Usuario
    {
        public int Codigo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
