using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using nutricion_examen.Models;

namespace nutricion_examen.Controllers
{
    public class EncuestaFrecuenciaController : Controller
    {
        // GET: EncuestaFrecuencia
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<Paciente>("sp_traer_encuesta_frec"));
        }

        // GET: EncuestaFrecuencia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EncuestaFrecuencia/Create
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
                return View(DapperORM.ReturnList<Encuesta_Frecuencia>("sp_traer_frecById", param).FirstOrDefault<Encuesta_Frecuencia>());
            }
        }

        // POST: EncuestaFrecuencia/Create
        [HttpPost]
        public ActionResult Create(Encuesta_Frecuencia encuesta_frecuencia)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", encuesta_frecuencia.Id_Frecuencia);
            param.Add("@alimentos", encuesta_frecuencia.Alimentos);
            param.Add("@frecuencia", encuesta_frecuencia.Frecuencia);
            param.Add("@cantidad", encuesta_frecuencia.Cantidad_Gr_Cc);
            param.Add("@obs", encuesta_frecuencia.Observaciones);
            param.Add("@id_ficha", encuesta_frecuencia.Id_Ficha);
            DapperORM.ExecuteWithoutReturn("sp_Add_EncuestaFrec", param);

            return RedirectToAction("Index");
        }

        // GET: EncuestaFrecuencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EncuestaFrecuencia/Edit/5
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

        // GET: EncuestaFrecuencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EncuestaFrecuencia/Delete/5
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
