using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_App.Controllers
{
    public class AccountController : Controller
    {


        public static string physicalWebRootPath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/ServerConnection.txt");
        public static string[] fileContents = System.IO.File.ReadAllLines(physicalWebRootPath);

        string _servername = fileContents[0].ToString();
        string _serverusername = fileContents[1].ToString();
        string _serverpass = fileContents[2].ToString();
        string _apiUrl = fileContents[3].ToString();
        string _database = "PmsLite";

       public AccountController()
        { 

        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            

            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult checkLogin(FormCollection frm) {
            String name = frm["txtUserName"].ToString();
            String password = frm["txtPassword"].ToString();
            Console.WriteLine(name);
            ViewBag.Message = "Your application .";
            return RedirectToAction("Login");
                
        }
    }
}