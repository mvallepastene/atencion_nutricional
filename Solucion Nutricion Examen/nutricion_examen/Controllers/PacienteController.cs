using Dapper;
using nutricion_examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace nutricion_examen.Controllers
{
    [Authorize]
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<Paciente>("sp_traer_Paciente"));
        }

        // GET: Paciente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Paciente/Create
        public ActionResult Create(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                //var res = DapperORM.ReturnList<Agenda>("sp_getAgendaById",param).FirstOrDefault<Agenda>();
                //return Json(new {datos = res },JsonRequestBehavior.AllowGet);
                return View(DapperORM.ReturnList<Agenda>("sp_getAgendaById", param).FirstOrDefault<Agenda>());
            }
        }
        // POST: Paciente/Create
        [HttpPost]
        public ActionResult Create(Paciente paciente)
        {
            // TODO: Add insert logic here
            DynamicParameters param = new DynamicParameters();
            param.Add("@id_paciente", paciente.Id_Paciente);
            param.Add("@rut", paciente.Rut);
            param.Add("@nombre", paciente.Nombre);
            param.Add("@apellido", paciente.Apellido);
            param.Add("@edad", paciente.Edad);
            param.Add("@fecha_nacimiento", paciente.Fecha_Nacimiento);
            param.Add("@numero_Tel", paciente.Numero_Tel);
            param.Add("@genero", paciente.Genero);
            param.Add("@direccion", paciente.Direccion);
            param.Add("@comuna", paciente.Comuna);
            param.Add("@email", paciente.Email);
            param.Add("@prevision", paciente.Prevision);
            param.Add("@ocupacion", paciente.Ocupacion);
            param.Add("@id_agenda", paciente.Id_Agenda);
            DapperORM.ExecuteWithoutReturn("sp_agregar_actualizar_Paciente", param);

            return RedirectToAction("Index");
            
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Paciente/Edit/5
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

        // GET: Paciente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Paciente/Delete/5
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
        public ActionResult ListaAgendas()
        {
            var result = DapperORM.ReturnList<Agenda>("sp_traer_Agenda");
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }
    }
}
