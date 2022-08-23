using HadithSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace HadithSearch.Controllers
{
    public class HadithController : Controller
    {
        DB_HADITHSEARCHEntities db = new DB_HADITHSEARCHEntities();

        // GET: Hadith
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AjouterHadith()
        {
            try
            {
                ViewBag.listeHadith = db.HADITH.ToList();
                ViewBag.listeTransmetteur = db.TRANSMETTEUR.ToList();
                return View();
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        public ActionResult AjouterHadith(HADITH hadith)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.HADITH.Add(hadith);
                    db.SaveChanges();
                }
                return RedirectToAction("AjouterHadith");
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }
    }
}