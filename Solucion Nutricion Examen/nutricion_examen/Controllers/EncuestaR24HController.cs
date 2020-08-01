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
        public ActionResult Create(EncuestaR24H encuesta)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@id_r24h", encuesta.Id_R24h);
                param.Add("@dia_de_semana", encuesta.Dia_Semana);
                param.Add("@hora", encuesta.Hora);
                param.Add("@minuta", encuesta.Minuta);
                param.Add("@ingredientes", encuesta.Ingredientes);
                param.Add("@medidas_caseras", encuesta.Medidas_Caseras);
                param.Add("@cantidad_gr_ml_total", encuesta.Cantidad_Gr_Ml_Total);
                param.Add("@observaciones", encuesta.Observaciones);
                param.Add("@id_ficha", encuesta.Id_Ficha);

                var result = DapperORM.ExecuteReturnScalar<EncuestaR24H>("sp_agregar_actualizar_Paciente", param);
                return Json(new { res = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return Json(new { res = error }, JsonRequestBehavior.AllowGet);
            }
            //return RedirectToAction("Index");


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
            var result = DapperORM.ReturnList<Ficha_Medica_Paciente>("sp_traerInfoFichaByIdPaciente"); //**FALTA AGREGAR EL NOMBRE CORRECTO DEL PROCEDIMIENTO DE TRAER FICHA PACIENTE**/
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }
    }
}
