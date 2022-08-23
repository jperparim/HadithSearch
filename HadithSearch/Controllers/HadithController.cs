using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HadithSearch.Controllers
{
    public class HadithController : Controller
    {
        // GET: Hadith
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AjouterHadith()
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