using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using nutricion_examen.Models;


namespace nutricion_examen.Controllers
{
    public class EncuestaR24HController : Controller
    {
        // GET: Encuesta_R24h
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<EncuestaR24H>("sp_traer_EncuestaR24h"));
        }

        // GET: Encuesta_R24h/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Encuesta_R24h/Create
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
                return View(DapperORM.ReturnList<EncuestaR24H>("sp_traer_EncuestaR24hById", param).FirstOrDefault<EncuestaR24H>());
            }
        }

        // POST: Encuesta_R24h/Create
        [HttpPost]
        public ActionResult Create(EncuestaR24H encuestaR24H)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id_r24h", encuestaR24H.Id_R24h);
            param.Add("@dia_de_semana", encuestaR24H.Dia_Semana);
            param.Add("@hora", encuestaR24H.Hora);
            param.Add("@minuta", encuestaR24H.Minuta);
            param.Add("@ingredientes", encuestaR24H.Ingredientes);
            param.Add("@medidas_caseras", encuestaR24H.Medidas_Caseras);
            param.Add("@cantidad_gr_ml_total", encuestaR24H.Cantidad_Gr_Ml_Total);
            param.Add("@observaciones", encuestaR24H.Observaciones);
            param.Add("@id_ficha", encuestaR24H.Id_Ficha);
            DapperORM.ExecuteWithoutReturn("sp_Agre_Actua_EncuestaR24H", param);

            return RedirectToAction("Index");

        }

        // GET: Encuesta_R24h/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Encuesta_R24h/Edit/5
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

        // GET: Encuesta_R24h/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Encuesta_R24h/Delete/5
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
        public ActionResult ListaFicha()
        {
            var result = DapperORM.ReturnList<Ficha_Medica_Paciente>("FALTA ADD"); //**FALTA AGREGAR EL NOMBRE CORRECTO DEL PROCEDIMIENTO DE TRAER FICHA PACIENTE**//
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }
    }
}
