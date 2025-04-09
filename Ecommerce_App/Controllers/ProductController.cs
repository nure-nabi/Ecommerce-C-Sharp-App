using DAL.Interface;
using DAL.Interface.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_App.Controllers
{
    public class ProductController : Controller
    {

        public ICategoryGroup _ICategoryGroup;
        public ICategorySubGroup _ICategorySubGroup;

        public ProductController(ICategoryGroup ICategoryGroup, ICategorySubGroup ICategorySubGroup)
        {
            _ICategoryGroup = ICategoryGroup;
            _ICategorySubGroup = ICategorySubGroup;
        }
        // GET: Product
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult PoductDetails(int categoryId,string CategoryName)
        {
            ViewBag._categoryId = categoryId;
            ViewBag._CategoryName = CategoryName;
           DataSet ds =  _ICategorySubGroup.ShowCategorySubGroupById(categoryId);
            ViewBag._listCategoryList = ds.Tables[0];
            return View();
        }
    }
}