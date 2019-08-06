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

        public ActionResult Listado()
        {
            List<Persona> lstPesona = new List<Persona>();

            p.nombre = "Lizarzaburu";
            p.apellido = "Steveto";
            p.edad = 21;
            lstPesona.Add(p);

            p = new Persona();

            p.nombre = "Velazco";
            p.apellido = "Francis";
            p.edad = 21;
            lstPesona.Add(p);

            return View(lstPesona);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            PersonaCRUD p = new PersonaCRUD();
            DataTable dt = p.listar();
            return View("Listar", dt);
        }


        public ActionResult Registrar()
        {
            return View("Registrar");
        }

        public ActionResult RegistrarPersona(FormCollection frm,string action)
        {
            if (action == "Registrar")
            {
                PersonaCRUD p = new PersonaCRUD();
                string nombre = frm["txtnombres"];
                string apellido = frm["txtapellidos"];
                int edad = Convert.ToInt32(frm["txtedad"]);
                string direccion = frm["txtdireccion"];
                DateTime fecha = Convert.ToDateTime(frm["txtfecha"]);
                p.Registrar(nombre, apellido, edad, direccion, fecha);
                return RedirectToAction("Listar","Persona");
            }
            else
            {
                return RedirectToAction("Listar", "Persona");
            }
            
        }


        public ActionResult Editar(int codigo)
        {
            PersonaCRUD p = new PersonaCRUD();
            DataTable dt = p.ListarxID(codigo);
            return View("Editar",dt);
        }

        public ActionResult EditarPersona(FormCollection frm , string action)
        {
            if (action == "Editar")
            {
                PersonaCRUD p = new PersonaCRUD();
                int codigo = Convert.ToInt32(frm["codigo"]);
                string nombre = frm["txtnombres"];
                string apellido = frm["txtapellidos"];
                int edad = Convert.ToInt32(frm["txtedad"]);
                string direccion = frm["txtdireccion"];
                DateTime fecha = Convert.ToDateTime(frm["txtfecha"]);
                p.Editar(codigo,nombre, apellido, edad, direccion, fecha);

                return RedirectToAction("Listar", "Persona");
            }
            else
            {
                return RedirectToAction("Listar", "Persona");
            }
        }

        

    }
}
