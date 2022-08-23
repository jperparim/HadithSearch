using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HadithSearch.Controllers
{
    public class ChapitreController : Controller
    {
        // GET: Chapitre
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AjouterChapitre()
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