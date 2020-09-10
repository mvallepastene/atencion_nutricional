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
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Acceso access)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@usr", access.Usuario);
                param.Add("@psw", access.Pass);
                param.Add("@tUsr", access.Tipo_Usuario);
                param.Add("@idNutri", access.Id_Nutricionista);

                int result = DapperORM.ExecuteReturnScalar<Acceso>("sp_insertAcceso", param);
                return Json(new { res = result }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return Json(new { res = error }, JsonRequestBehavior.AllowGet);
            }
        }

        //metodo que elimina los nutricionistas para asociarlos al acceso.
        [HttpPost]
        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@id", id);
            int result = DapperORM.ExecuteReturnScalar<Acceso>("sp_deleteUser", param);

            return Json(new { res = result }, JsonRequestBehavior.AllowGet);
        }

        //metodo que retorna los nutricionistas para asociarlos al acceso.
        [HttpGet]
        public ActionResult GetNutri()
        {
            var result = DapperORM.ReturnList<Nutricionista>("sp_traer_nutri").ToList();

            return Json(new { res = result }, JsonRequestBehavior.AllowGet);
        }

        //action que retorna el Id del usuario logueado
        [HttpPost]
        public ActionResult ReturnIdUsuario(string nombreUsr)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@nomUsr", nombreUsr);
                var id = DapperORM.ReturnList<int>("returnIdUser",param).ToList();
                return Json(new { res = id }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return Json(new { res = error }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
