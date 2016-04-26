using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace solid_spork.Controllers
{
    public class queryController : Controller
    {
        //
        // GET: /query/

        public ActionResult Query()
        {
            return View();
        }

        public ActionResult QueryDetails(int id, string details)
        {
            ViewBag.Title = "solid-work.com " + details ?? "";
            return View();
        }


    }
}
