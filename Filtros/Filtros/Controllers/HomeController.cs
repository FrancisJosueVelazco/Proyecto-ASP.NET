using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [Authorize]
        public string Index()
        {
            return "Este es mi controlador Home";
        }


        //[Authorize(Roles="Admin")]
        //[OutputCache (Duration=10)]
        [ActionName("Hora")]
        public string HoraActual()
        {
            return cadenaHora();
        }

        [NonAction]
        public string cadenaHora()
        {
            return "Son las: "+DateTime.Now.ToString("T");
        }

    }
}
