using nutricion_examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;

namespace nutricion_examen.Controllers
{
    public class AgendaController : Controller
    {
        // GET: Agenda
        public ActionResult Index()
        {
            //hacemos la peticion a la bd
           
            return View(DapperORM.ReturnList<Agenda>("sp_traer_Agenda"));
        }

        // GET: Agenda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Agenda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agenda/Create
        [HttpPost]
        public ActionResult Create(Agenda agenda)
        {

            // TODO: Add insert logic here

            DynamicParameters param = new DynamicParameters();
            param.Add("@id_agenda", agenda.Id_Agenda);
            param.Add("@rut", agenda.Rut);
            param.Add("@nombre", agenda.Nombre);
            param.Add("@apellido", agenda.Apellido);
            param.Add("@fecha_nacimiento", agenda.Fecha_Nacimiento);
            param.Add("@numero_tel", agenda.Numero_Tel);
            param.Add("@email", agenda.Email);
            param.Add("@fecha_cita", agenda.Fecha_Cita);
            param.Add("@hora_cita", agenda.Hora_Cita);
            param.Add("@id_estado", agenda.Id_Estado);
            DapperORM.ExecuteWithoutReturn("sp_agregarOActualiza_Agenda", param);


            return RedirectToAction("Index");
          
        }

        // GET: Agenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Agenda/Edit/5
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

        // GET: Agenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agenda/Delete/5
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
        [HttpGet]
        public ActionResult ListaEstadoAgenda()
        {
            var result = DapperORM.ReturnList<Estado_Agenda>("traer_Estado");
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }
    }
}
