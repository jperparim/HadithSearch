using HadithSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace HadithSearch.Controllers
{
    public class AuthenticiteController : Controller
    {
        DB_HADITHSEARCHEntities db = new DB_HADITHSEARCHEntities();

        // GET: Authenticite
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AjouterAuthenticite()
        {
            try
            {
                ViewBag.listeAuthenticite = db.AUTHENTICITE.ToList();

                return View();
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }


        [HttpPost]
        public ActionResult AjouterAuthenticite(AUTHENTICITE authenticite)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    db.AUTHENTICITE.Add(authenticite);
                    db.SaveChanges();
                }
                return RedirectToAction("AjouterAuthenticite");
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }
    }
}