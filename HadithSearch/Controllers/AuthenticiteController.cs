using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HadithSearch.Controllers
{
    public class AuthenticiteController : Controller
    {
        // GET: Authenticite
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AjouterAuthenticite()
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