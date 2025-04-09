using DAL.Interface;
using DAL.Interface.Account;
using DAL.Master;
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

        public IAccount _Account { get; set; }
       
        public AccountController(IAccount Account)
        {
            _Account = Account;
           
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = TempData["Message"];
            TempData["Message"]= "";
            return View();
        }
        public ActionResult Register()
        {


            return View();
        }

        public ActionResult RegisterUser(FormCollection frm) 
        {

             _Account.Model.UserName = frm["UserName"].ToString();
            _Account.Model.MobileNo = frm["MobileNo"].ToString();
            _Account.Model.Email = frm["Email"].ToString();
            _Account.Model.Address = frm["Address"].ToString();
            _Account.Model.City = frm["City"].ToString();
            _Account.Model.State = frm["State"].ToString();
            _Account.Model.Pincode = frm["Pincode"].ToString();
            _Account.Model.Password = frm["Password"].ToString();

           string value = _Account.saveUser();
            ViewBag.Message = "User Inserted Successfully";
            return RedirectToAction("Register");
        }

        public ActionResult checkLogin(FormCollection frm) {
            _Account.Model.UserName = frm["txtUserName"].ToString();
           _Account.Model.Password = frm["txtPassword"].ToString();

            DAL.Account.AccountViewModel value = _Account.checkUser();


            if (_Account.Model.UserName.Equals("admin@gmail.com") && _Account.Model.Password.Equals("admin"))
            {
                return RedirectToAction("Index","Admin");
            }

            if (value.UserName != null)
            {
                ViewBag._LoginSesion = _Account.Model.UserName;
                TempData["_LoginSesion"] = ViewBag._LoginSesion;
                return RedirectToAction("Index", "Home");
            }
            else 
            {
                ViewBag.Message = "Something on server error.";
                TempData["Message"] = ViewBag.Message;
                return RedirectToAction("Login");
            }
          
            
                
        }
    }
}