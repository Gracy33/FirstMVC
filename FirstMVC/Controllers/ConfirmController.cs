using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class ConfirmController : Controller
    {
        //
        // GET: /Confirm/
        /*public ActionResult Index()
        {
            return View();
        }*/

        [HttpGet]
        public ViewResult confirm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult confirm(Response response)
        {
            if (ModelState.IsValid)
            {
                return View("Thanx", response);
            }
            else
            {
                return View();
            }
        }
	}
}