using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HadithSearch.Controllers
{
    public class RecueilController : Controller
    {
        // GET: Recueil
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjouterRecueil()
        {
            try
            {
                return View();
            }
            catch(Exception e)
            {
                return HttpNotFound();
            }
        }
    }
}