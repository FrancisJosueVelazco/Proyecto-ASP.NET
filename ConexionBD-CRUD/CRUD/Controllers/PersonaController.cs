using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Datos;
using Capa_Entidad;
using Capa_Negocio;

namespace CRUD.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/

        public ActionResult Index()
        {
            // FINALMENTE INSTANCIAMOS EL OBJETO QUE TRAE EL METODO
            N_Persona client = new N_Persona();

            List<Persona> listado = client.ObtenerPersona();

            return View(listado);
        }

        //
        // GET: /Persona/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Persona/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Persona/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Persona/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Persona/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Persona/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Persona/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
