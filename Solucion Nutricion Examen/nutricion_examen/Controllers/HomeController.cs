using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using nutricion_examen.Models;
using Dapper;

namespace nutricion_examen.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn(string message = "")
        {
            ViewBag.Message = message;

            return View();
        }

        [HttpPost]
        public ActionResult LogIn(string usr, string psw)
        {
            if (!string.IsNullOrEmpty(usr) && !string.IsNullOrEmpty(psw))
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@usr", usr);
                param.Add("@psw", psw);

                List<Acceso> _list = new List<Acceso>();
                _list = DapperORM.ReturnList<Acceso>("sp_getUsuario", param).ToList();

                var User = _list.Select(u => new Acceso
                {
                    Id_Acceso = u.Id_Acceso,
                    Usuario = u.Usuario,
                    Pass = u.Pass,
                    Tipo_Usuario = u.Tipo_Usuario,
                    
                });
                if (User != null)
                {
                    foreach (var item in User)
                    {
                        FormsAuthentication.SetAuthCookie(item.Usuario, true);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("LogIn", new { message = "No encontramos sus datos ingresados" });

                }

            }
            else
            {
                return RedirectToAction("LogIn", new { message = "Llena los datos para iniciar Sesion" });

            }

        }

        [Authorize]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}