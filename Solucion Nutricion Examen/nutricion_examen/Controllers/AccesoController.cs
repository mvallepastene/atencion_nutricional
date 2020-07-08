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
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<Acceso>("sp_getAllUsers"));
        }

        // GET: Acceso/Details/5
        public ActionResult Details(int id)
        {
             return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
            int result = DapperORM.ExecuteReturnScalar<Acceso>("sp_deleteUser", param);

            return Json(new { res = result }, JsonRequestBehavior.AllowGet);
        }
    }
}
