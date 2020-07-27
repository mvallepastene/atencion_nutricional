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
        [Authorize]
        // GET: Agenda
        public ActionResult Index()
        {
            //hacemos la peticion a la bd
           
            return View(DapperORM.ReturnList<Agenda>("sp_traer_Agenda"));
        }
        [Authorize]
        // GET: Agenda/Details/5
        public ActionResult Details(int id)
        {
            //Generamos el paramatro dinamico que le enviaremos al stored procedure sp_getAgendaById
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);

            List<Agenda> ag = new List<Agenda>();

            ag = DapperORM.ReturnList<Agenda>("sp_getAgendaById", param).ToList();
            return Json(new { data = ag },JsonRequestBehavior.AllowGet);
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
          int result =  DapperORM.ExecuteReturnScalar<Agenda>("sp_agregarOActualiza_Agenda", param);


            return Json( new { res = result }, JsonRequestBehavior.AllowGet);
          
        }
        [Authorize]
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
        [Authorize]
        [HttpGet]
        public ActionResult ListaEstadoAgenda()
        {
            var result = DapperORM.ReturnList<Estado_Agenda>("sp_traer_Estados");
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }

        
        [HttpPost]
        public ActionResult RetornarAgendasActivas()
        {
            var result = DapperORM.ReturnList<Agenda>("sp_returnAgendasActivas").FirstOrDefault<Agenda>();

            return Json(new { res = result}, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RetornarCantidadPacientes()
        {
            var result = DapperORM.ReturnList<Paciente>("sp_returnAllPacientes").FirstOrDefault<Paciente>();

            return Json(new { res = result }, JsonRequestBehavior.AllowGet);
        }
    }
}
