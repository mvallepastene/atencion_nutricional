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
            return View(DapperORM.ReturnList<Estado_Agenda>("traer_estado"));
        }

        // GET: Estado_Agenda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estado_Agenda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estado_Agenda/Create
        [HttpPost]
        public ActionResult Create(Estado_Agenda estado_agenda)
        {
            try
            {
                // TODO: Add insert logic here
                DynamicParameters param = new DynamicParameters();
                param.Add("@nom_estado",estado_agenda.Nombre_Estado);
                DapperORM.ExecuteWithoutReturn("sp_agregar_estado", param);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estado_Agenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estado_Agenda/Edit/5
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
