using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using nutricion_examen.Models;

namespace nutricion_examen.Controllers
{
    public class Estado_AgendaController : Controller
    {
        // GET: Estado_Agenda
        public ActionResult Index()
        {
            //hacemos la peticion a la bd
            
            return View(DapperORM.ReturnList<Estado_Agenda>("traer_estado"));
           
        }

        // GET: Estado_Agenda/Details/5
        public ActionResult Details(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
            List<Estado_Agenda> ag = new List<Estado_Agenda>();
            ag = DapperORM.ReturnList<Estado_Agenda>("sp_traer_estadoById", param).ToList();
            return Json(new { data = ag }, JsonRequestBehavior.AllowGet);
            
        }

        // GET: Estado_Agenda/Create
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
                return View(DapperORM.ReturnList<Estado_Agenda>("sp_traer_estadoById", param).FirstOrDefault<Estado_Agenda>());
            }
        }

        // POST: Estado_Agenda/Create
        [HttpPost]
        public ActionResult Create(Estado_Agenda estado_agenda)
        {
           
                // TODO: Add insert logic here
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", estado_agenda.Id_Estado);
                param.Add("@NOM_ESTADO", estado_agenda.Nombre_Estado);
               
                DapperORM.ExecuteWithoutReturn("sp_agregar_o_actualizar", param);

                return RedirectToAction("Index");
            
        }

        // POST: Estado_Agenda/Edit/5
        [HttpPost]
        public ActionResult Edit(Estado_Agenda estado)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", estado.Id_Estado);
            param.Add("@nom_estado", estado.Nombre_Estado);
            int status = DapperORM.ExecuteReturnScalar<Estado_Agenda>("sp_Actualiza_EstadoAgenda", param);
            return Json(new {r = status }, JsonRequestBehavior.AllowGet);
        }

       

        // GET: Estado_Agenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estado_Agenda/Delete/5
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
