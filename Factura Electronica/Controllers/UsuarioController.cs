using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Factura_Electronica.Controllers
{
    public class UsuarioController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            try
            {

                Models.Usuario Usuariologueado = new Models.Usuario();
                Usuariologueado.Id = form.Get("NombreUsuario");
                Usuariologueado.Clave = form.Get("ClaveUsuario");
                Usuariologueado.Obtienetokendehacienda();
                HttpResponseMessage response = Request.CreateResponse<String>(HttpStatusCode.Created, Usuariologueado.Token);
                return response;
            }
            catch (Exception t)
            {

                HttpResponseMessage response = Request.CreateResponse<String>(HttpStatusCode.Created, "Ocurrio un error: " + t.Message);
                return response;
            }
        }
    }
}

