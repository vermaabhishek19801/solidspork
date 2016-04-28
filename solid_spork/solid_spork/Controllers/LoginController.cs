
using System.IO;
using System.Threading;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Drive.v2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using solid_spork.Models;
using System.Linq;
namespace solid_spork.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        private Entities db = new Entities();
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {

            return View();
        }
        string ClientId = "195756336238-mqn8cp6phjb6g1u88o4pqt2dpjvduifr.apps.googleusercontent.com",
                 ClientSecret = "pLhsjiGcs4JwtuyPvIFZ0a3r";
        static string[] Scopes = { CalendarService.Scope.Calendar, CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";

        public ActionResult GoogleAuthenticate()
        {

            string Email = "mail.deepak899@gmail.com";
            int UserId = 0;
            int UserType = 0;
            var data = db.Users.FirstOrDefault(m => m.Email == Email.ToLower());
            if (data != null)
            {
                UserId = data.UserId;
                UserType = data.UserType;
                if (data.IsActive == false)
                {
                    return RedirectToAction("index", "home");
                }
            }
            else
            {
                var content = new User();
                content.UserType = 1;
                content.Email = Email;
                content.DOJ = System.DateTime.UtcNow;
                content.IsActive = true;
                db.Users.Add(content);
                db.SaveChanges();
                UserType = 1;
                UserId = content.UserId;
            }

            Session["UserId"] = UserId;
            Session["Email"] = Email;
            Session["UserType"] = UserType;
            LoggedInUser.Email = Email;
            LoggedInUser.UserId = UserId;
            LoggedInUser.UserType = UserType;
            return RedirectToAction("index", "home");
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            LoggedInUser.UserId = 0;
            LoggedInUser.Email = "";
            LoggedInUser.UserType = 0;
            return RedirectToAction("index", "home");
        }
    }

}

