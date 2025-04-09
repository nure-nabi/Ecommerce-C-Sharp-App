using DAL.Interface.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_App.Controllers
{
    public class SizeController : Controller
    {
        public ISize _iSize;

        public SizeController(ISize iSize)
        {
            _iSize = iSize;
        }
        // GET: Size
        public ActionResult Index()
        {
            DataSet ds = _iSize.showSize();
            ViewBag._SizeLis = ds.Tables[0];
          
            return View();
        }

        public ActionResult saveSize(FormCollection frm)
        {

            _iSize.Model.SizeName = frm["SizeName"].ToString();
            _iSize.Model.BrandSize = frm["BrandSize"].ToString();
            _iSize.Model.ToFit = frm["ToFit"].ToString();
            _iSize.Model.EntryDate = DateTime.Now.ToString("dd/mm/yyyy hh:mm tt");
            _iSize.Model.Tag = "NEW";

          string value =  _iSize.save();

            if (value != null) {
                ViewBag._Message = "Save data";
            }
            ViewBag._SizeLis = _iSize.showSize(); 
            return RedirectToAction("Index");

        }
    }
}