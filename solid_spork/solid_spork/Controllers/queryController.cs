using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using solid_spork.DL;
using solid_spork.Models;

namespace solid_spork.Controllers
{
    public class QueryController : Controller
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
        public JsonResult CreateNewQuery(QueryData data)
        {
           
            if (Session["UserId"] == null)
            {
                return Json("0", JsonRequestBehavior.AllowGet);
            }
            bool flag = false;
            Query Obj = new Models.Query();
            Obj.AddedBy = (int)Session["UserId"];
            Obj.AddedOn = DateTime.UtcNow;
            Obj.IsActive = true;
            Obj.QueryData = data.Query;
            Obj.QueryDescription = data.QueryDescription;
            QueryDl ObjDl = new QueryDl();
            flag = ObjDl.CreateNewQuery(Obj);
            return Json(flag, JsonRequestBehavior.AllowGet);
        }

    }
}
