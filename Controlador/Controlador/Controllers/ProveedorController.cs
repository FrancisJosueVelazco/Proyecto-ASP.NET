using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controlador.Controllers
{
    public class ProveedorController : Controller
    {
        //
        // GET: /Proveedor/

        public string TodosLosProveedores()
        {
            return @"<ul>
                <li>ACampos</li>
                <li>ACampos</li>
                <li>ACampos</li>
                </ul>";

        }

    }
}
