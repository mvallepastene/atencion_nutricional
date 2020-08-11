using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nutricion_examen.Controllers
{
    public class FrontEndController : Controller
    {
        //GET: FrontEnd/Receta/
        public ActionResult Receta1()
        {
            return View();
        }
        public ActionResult Receta2()
        {
            return View();
        }
        public ActionResult Receta3()
        {
            return View();
        }
        public ActionResult Receta4()
        {
            return View();
        }
        public ActionResult Receta5()
        {
            return View();
        }
        public ActionResult Receta6()
        {
            return View();
        }
        public ActionResult Receta7()
        {
            return View();
        }
        public ActionResult Receta8()
        {
            return View();
        }
        //GET: FrontEnd/Quien Soy/
        public ActionResult Quien_soy()
        {
            return View();
        }
        // GET: FrontEnd
        public ActionResult Index()
        {
            return View();
        }
        // GET: BLOG
        public ActionResult Blog()
        {
            return View();
        }

        // GET: POSTS
        public ActionResult Posts1()
        {
            return View();
        }
        public ActionResult Posts2()
        {
            return View();
        }
        public ActionResult Posts3()
        {
            return View();
        }
        public ActionResult Posts4()
        {
            return View();
        }
        public ActionResult Posts5()
        {
            return View();
        }
        public ActionResult Posts6()
        {
            return View();
        }

        // GET: FrontEnd/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FrontEnd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FrontEnd/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FrontEnd/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FrontEnd/Edit/5
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
        

        // GET: FrontEnd/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FrontEnd/Delete/5
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
