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
        public bool Autenticar_Usuario(string pEmail, string pSenha)
        {
            return true;
        }
    }

    public class Usuario
    {
        public int Codigo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
