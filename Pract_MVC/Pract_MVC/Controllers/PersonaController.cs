using Pract_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace Pract_MVC.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/
        Persona p = new Persona();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            CRUD c = new CRUD();
            DataTable dt = c.listar();
            return View("Listar", dt);
        }

        public ActionResult Listado()
        {
            List<Persona> lstPesona = new List<Persona>();
            
            p.nombre = "Lizarzaburu";
            p.apellido = "Steveto";
            p.edad=21;
            lstPesona.Add(p);

            p = new Persona();

            p.nombre = "Velazco";
            p.apellido = "Francis";
            p.edad = 21;
            lstPesona.Add(p);

            return View(lstPesona);
        }

    }
}
