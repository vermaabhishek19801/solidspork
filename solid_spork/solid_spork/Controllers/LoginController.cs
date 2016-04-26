
using System.IO;
using System.Threading;
using System.Web.Mvc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
namespace solid_spork.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
        public static ClientSecrets secrets = new ClientSecrets()
        {
            ClientId = "195756336238-11s1ihlqtj36pdbnpt90b63l10t3k7r8.apps.googleusercontent.com",
            ClientSecret = "N8rq_pwmTe5BuspXb0h9eJPB"
        };

        // Configuration that you probably don't need to change.
        static public string APP_NAME = "Google+ C# Quickstart";

        static public string[] SCOPES = { };
        // Uncomment to retrieve email.
        //static public string[] SCOPES = { PlusService.Scope.PlusLogin, PlusService.Scope.UserinfoEmail };

        // Stores token response info such as the access token and refresh token.
        private TokenResponse token;

        // Used to peform API calls against Google+.

        public ActionResult GoogleAuthenticate()
        {

            return RedirectToAction("index", "home");
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            LoggedInUser.UserId = 0;
            LoggedInUser.email = "";
            LoggedInUser.UserType = -1;

            return RedirectToAction("index", "home");
        }
    }

}

