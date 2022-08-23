using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HadithSearch.Controllers
{
    public class TransmetteurController : Controller
    {
        // GET: Transmetteur
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AjouterTransmetteur()
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