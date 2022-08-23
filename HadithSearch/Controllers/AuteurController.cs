using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HadithSearch.Controllers
{
    public class AuteurController : Controller
    {
        // GET: Auteur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjoutAuteur()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                return HttpNotFound();
            }
        }
    }
}