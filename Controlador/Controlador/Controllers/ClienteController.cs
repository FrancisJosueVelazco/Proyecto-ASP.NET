using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controlador.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/

        public ActionResult Buscar(string nombre)
        {
            var input = Server.HtmlEncode(nombre);
            return Content(input);
        }

    }
}
