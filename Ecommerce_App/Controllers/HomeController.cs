using DAL.Interface;
using DAL.Interface.Master;
using DAL.Interface.ProductMaster;
using DAL.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_App.Controllers
{
    public class HomeController : Controller
    {
        public ICategoryGroup _ICategoryGroup;
        public ICategorySubGroup _ICategorySubGroup;
        public IProductMaster _IProductMaster;

        public HomeController(ICategoryGroup ICategoryGroup, ICategorySubGroup ICategorySubGroup, IProductMaster IProductMaster)
        {
            _ICategoryGroup = ICategoryGroup;
            _ICategorySubGroup = ICategorySubGroup;
            _IProductMaster = IProductMaster;
        }

        public ActionResult Index()
        {
            ViewBag._LoginSesion = TempData["_LoginSesion"];
            TempData["_LoginSesion"] = "";

            DataSet ds = _ICategoryGroup.GridReport();
            ViewBag._listCategory = ds.Tables[0];
           DataSet dsSub= _ICategorySubGroup.ShowCategorySubGroup();
            ViewBag._ListSubCategory = dsSub.Tables[0];
            //List<CategoryViewModels> listCategory= _ICategoryGroup.ShowCategory();
            //ViewBag._listCategory = listCategory;
            DataSet dsProduct =  _IProductMaster.getProduct();
            ViewBag._ListProduct = dsProduct.Tables[0];
            return View();
        }

    }
}  