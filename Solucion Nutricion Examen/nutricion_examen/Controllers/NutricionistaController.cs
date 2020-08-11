using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nutricion_examen.Models;
using Dapper;


namespace nutricion_examen.Controllers
{
    [Authorize]
    public class NutricionistaController : Controller
    {
        // GET: Nutricionista
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<Nutricionista>("sp_traer_nutri"));
        }

        // GET: Nutricionista/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);

                var result = DapperORM.ReturnList<Nutricionista>("sp_getNutriById", param).FirstOrDefault<Nutricionista>();
                return Json(new { res = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return Json(new { res = error }, JsonRequestBehavior.AllowGet);
            }
            
        }

        // GET: Nutricionista/Create
        public ActionResult Create(int id= 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                return View(DapperORM.ReturnList<Nutricionista>("sp_getNutryById", param).FirstOrDefault<Nutricionista>());
            }
        }
        // POST: Nutricionista/Create
        [HttpPost]
        public ActionResult Create(Nutricionista nutricionista)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", nutricionista.Id_Nutricionista);
                param.Add("@rut", nutricionista.Rut);
                param.Add("@nombre", nutricionista.Nombre);
                param.Add("@apellido", nutricionista.Apellido);
                param.Add("@edad", nutricionista.Edad);
                param.Add("@fecha_nac", nutricionista.Fecha_Nacimiento);
                param.Add("@tel", nutricionista.Numero_Tel);
                param.Add("@email", nutricionista.Email);
                param.Add("@especialidad", nutricionista.Especialidad);

                int result = DapperORM.ExecuteReturnScalar<Nutricionista>("sp_agregar_actualizar_nutri", param);

                return Json(new { res = result},JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                string error = ex.Message;

                return Json(new { res = error }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Nutricionista/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nutricionista/Edit/5
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

        // GET: Nutricionista/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nutricionista/Delete/5
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
