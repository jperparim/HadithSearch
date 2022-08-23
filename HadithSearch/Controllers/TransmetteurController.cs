using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using HadithSearch.Models;

namespace HadithSearch.Controllers
{
    public class TransmetteurController : Controller
    {
        DB_HADITHSEARCHEntities db = new DB_HADITHSEARCHEntities();

        // GET: Transmetteur
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AjouterTransmetteur()
        {
            try
            {
                ViewBag.listeTransmetteur = db.TRANSMETTEUR.ToList();
                return View();
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }


        [HttpPost]
        public ActionResult AjouterTransmetteur(TRANSMETTEUR transmetteur)
        {
            try
            {

                if(ModelState.IsValid)
                {
                    db.TRANSMETTEUR.Add(transmetteur);
                    db.SaveChanges();
                }
                return RedirectToAction("AjouterTransmetteur");
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }
    }
}