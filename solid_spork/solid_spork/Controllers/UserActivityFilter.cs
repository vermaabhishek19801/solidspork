using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace solid_spork
{
    public class UserActivityFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["UserId"] == null || HttpContext.Current.Session["UserType"] == null || (int)HttpContext.Current.Session["UserType"] != (int)UserType.User)
            {
                var url = new UrlHelper(filterContext.RequestContext);
                var loginUrl = url.Content("~/Home/Index");
                filterContext.HttpContext.Response.Redirect(loginUrl, true);

            }
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (HttpContext.Current.Session["UserId"] == null || HttpContext.Current.Session["UserType"] == null || (int)HttpContext.Current.Session["UserType"] != (int)UserType.User)
            {
                var url = new UrlHelper(filterContext.RequestContext);
                var loginUrl = url.Content("~/Home/Index");
                filterContext.HttpContext.Response.Redirect(loginUrl, true);

            }

        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["UserId"] == null || HttpContext.Current.Session["UserType"] == null || (int)HttpContext.Current.Session["UserType"] != (int)UserType.User)
            {
                var url = new UrlHelper(filterContext.RequestContext);
                var loginUrl = url.Content("~/Home/Index");
                filterContext.HttpContext.Response.Redirect(loginUrl, true);

            }
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (HttpContext.Current.Session["UserId"] == null || HttpContext.Current.Session["UserType"] == null || (int)HttpContext.Current.Session["UserType"] != (int)UserType.User)
            {
                var url = new UrlHelper(filterContext.RequestContext);
                var loginUrl = url.Content("~/Home/Index");
                filterContext.HttpContext.Response.Redirect(loginUrl, true);

            }
        }

    }
}
