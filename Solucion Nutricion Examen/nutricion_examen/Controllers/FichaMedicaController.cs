using Dapper;
using nutricion_examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nutricion_examen.Controllers
{
    public class FichaMedicaController : Controller
    {
        // GET: FichaMedica
        public ActionResult Index()
        {
            return View();
        }

        // GET: FichaMedica/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FichaMedica/Create
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

                return View(DapperORM.ReturnList<Paciente>("sp_traer_PacienteById", param).FirstOrDefault<Paciente>());
            }
        }

        // POST: FichaMedica/Create
        [HttpPost]
        public ActionResult Create(Ficha_Medica_Paciente fmp)
        {
            try
            {
                // TODO: Add insert logic here

                DynamicParameters param = new DynamicParameters();
                param.Add("@antecedentes", fmp.Ant_Familiares);
                param.Add("@alergias", fmp.Alergias);
                param.Add("@enfermedades", fmp.Enfermedades);
                param.Add("@peso", fmp.Peso);
                param.Add("@talla", fmp.Talla);
                param.Add("@req_prot", fmp.Req_Prot);
                param.Add("@req_cho", fmp.Req_Cho);
                param.Add("@req_lip", fmp.Req_Lip);
                param.Add("@prox_control", fmp.Prox_Control);
                param.Add("@cc", fmp.Circ_Cint);
                param.Add("@observaciones", fmp.Observaciones);
                param.Add("@factor_act", fmp.Req_Fac_Act);
                param.Add("@amdr_prot", fmp.Amdr_Prot);
                param.Add("@amdr_cho", fmp.Amdr_Cho);
                param.Add("@amdr_lip", fmp.Amdr_Lip);
                param.Add("@idPac", fmp.Id_Paciente);
                param.Add("@pesoReqPaciente", fmp.Peso_Requerido); 
                param.Add("@idUser", fmp.Id_Nutricionista);

               int result = DapperORM.ExecuteReturnScalar<Ficha_Medica_Paciente>("sp_insertDataFicha", param);

                return Json(new { res = result }, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return Json(new { res = error }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: FichaMedica/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FichaMedica/Edit/5
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

        // GET: FichaMedica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FichaMedica/Delete/5
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

        [HttpPost]
        public ActionResult ReturnCalculos(int id)
        {
            //creamos el parametro dinamico para traer los resultados mediante el id del paciente
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
          var res =  DapperORM.ReturnList<Ficha_Medica_Paciente>("sp_traerInfoFichaByIdPaciente", param).FirstOrDefault<Ficha_Medica_Paciente>();

            return Json(new { data = res }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RetornarCantidadFichas()
        {
            var result = DapperORM.ReturnList<Ficha_Medica_Paciente>("sp_returnAllFichas").FirstOrDefault<Ficha_Medica_Paciente>();

            return Json(new { res = result }, JsonRequestBehavior.AllowGet);
        }
    }
}
