using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using solid_spork.DL;
using solid_spork.Models;

namespace solid_spork.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {          
            return View();
        }
        public JsonResult GetQueries(SearchQuery SearchQuery)
        {

            bool flag = false;
            QueryDl ObjDl = new QueryDl();
            var data = ObjDl.GetLatestQuery(SearchQuery);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}
