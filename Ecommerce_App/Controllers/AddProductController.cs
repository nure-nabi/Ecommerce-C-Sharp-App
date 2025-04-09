using DAL.Interface;
using DAL.Interface.Master;
using DAL.Interface.ProductMaster;
using DAL.ProductMaster;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_App.Controllers
{
    public class AddProductController : Controller
    {
        public ICategoryGroup _ICategoryGroup;
        public ICategorySubGroup _ICategorySubGroup;
        public IProductMaster _IProductMaster;
        public ProductViewModels Model { get; set; }

        public AddProductController(ICategoryGroup ICategoryGroup, ICategorySubGroup ICategorySubGroup, IProductMaster IProductMaster)
        {
            _ICategoryGroup = ICategoryGroup;
            _ICategorySubGroup = ICategorySubGroup;
            _IProductMaster = IProductMaster;
            Model = new ProductViewModels();
        }
        // GET: AddProduct
        public ActionResult Index()
        {
            DataSet ds = _ICategoryGroup.GridReport();
            DataSet dss = _ICategorySubGroup.ShowCategorySubGroup();
            ViewBag._CategoryList = ds.Tables[0];
            ViewBag._SubCategoryList = dss.Tables[0];
            return View();
        }

        public ActionResult SaveProduct(FormCollection frm)
        {
            _IProductMaster.Model.ProductName = frm["product_name"].ToString();
            _IProductMaster.Model.ProductNameNepali = frm["product_name_nepali"].ToString();
            _IProductMaster.Model.Brand = frm["Brand"].ToString();
            _IProductMaster.Model.CategoryId = Convert.ToInt32(frm["categoryId"]);
            _IProductMaster.Model.SubCategoryId = Convert.ToInt32(frm["sub-categoryId"]);
            _IProductMaster.Model.Price = Convert.ToDouble(frm["Price"]);
            _IProductMaster.Model.Qty = Convert.ToInt32(frm["Qty"]);
            _IProductMaster.Model.is_active_flash_sale = true;
            _IProductMaster.Model.Tag = "NEW";
            _IProductMaster.saveProduct();
            return RedirectToAction("Index");
        
        }

        public PartialViewResult PartialViewAddVariation()
        {
            return PartialView("_PartialViewAddVariation");
        }

        //public PartialViewResult _AddColorVariation()
        //{
        //    return PartialView("_AddColorVariation");
        //}
    }
}