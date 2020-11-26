using nutricion_examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using Rotativa;

namespace nutricion_examen.Controllers
{
    public class ReporteController : Controller
    {
        // GET: Reporte
        public ActionResult Index()
        {
            //var list = DapperORM.ReturnList<Nutricionista>("sp_traer_nutri");

            //return Json(new { res = list }, JsonRequestBehavior.AllowGet);
            return View(DapperORM.ReturnList<Nutricionista>("sp_traer_nutri"));
        }

        public ActionResult getReport(DateTime fecDes, DateTime fecHas, string nutri)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@fechaDesde", fecDes);
            param.Add("@fechaHasta", fecHas);
            param.Add("@nombreNutri", nutri);


            //var result = DapperORM.ReturnList<Reporte>("sp_traerPacientesDia", param).ToList();
            //return Json(new {res = result }, JsonRequestBehavior.AllowGet);
            return View(DapperORM.ReturnList<Reporte>("sp_traerPacientesDia", param).ToList());
        }
        [HttpPost]
        public ActionResult Print(DateTime fecdes, DateTime fechas, string nutri)
        {
            return new ActionAsPdf("getReport", new { fecDes = fecdes, fecHas = fechas, Nutri = nutri} ) { FileName = "Reporte_"+DateTime.Now+".pdf" };
        }


    }
}
