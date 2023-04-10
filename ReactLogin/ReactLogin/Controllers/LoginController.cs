using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReactLogin.Controllers
{
    public class LoginController : ApiController
    {
      
        public Models.Usuario Get(string usuario,string contraseña)
        {
            Models.Usuario u = new Models.Usuario();
            u = Models.Usuario.Loguear(usuario,contraseña);
            return u;
        }
    }
}
