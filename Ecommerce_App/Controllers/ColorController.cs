using DAL.Interface.Master;
using DAL.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_App.Controllers
{
    public class ColorController : Controller
    {
        public IColor _IColor;

        public ColorController(IColor IColor)
        {
            _IColor = IColor;
        }
        // GET: Color
        public ActionResult Index()
        {
            _IColor.Model = new ColorViewModel();
            ViewBag.Message = TempData["Message"];
            TempData["Message"] = "";
            DataSet ds = _IColor.ShowColor();
            ViewBag._ColorList = ds.Tables[0];
           
            return View();
        }

        public ActionResult saveColor(FormCollection frm)
        {
            _IColor.Model.ColorName = frm["ColorName"].ToString();
            _IColor.Model.EntryDate = DateTime.Now.ToString("dd/mm/yyyy hh:mm tt");
            _IColor.Model.Tag = "NEW";

            _IColor.save();
            ViewBag.Message = "Save successfully";
            TempData["Message"] = ViewBag.Message;

            return RedirectToAction("Index");
        }
    }
}