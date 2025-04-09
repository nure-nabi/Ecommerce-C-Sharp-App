using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Interface;
using DAL.Interface.Master;
using DAL.Master;
namespace Ecommerce_App.Controllers
{
    public class AdminController : Controller
    {

        public ICategoryGroup _CategoryGroup;

        public ICategorySubGroup _ICategorySubGroup;

        public CategoryViewModels _CategoryViewModels  { get;set;}
        public CategorySubGroupModel _CategorySubGroupModel { get;set;}

        public AdminController(ICategoryGroup CategoryGroup, ICategorySubGroup iCategorySubGroup)
        {
            _CategoryGroup = CategoryGroup;
            _ICategorySubGroup = iCategorySubGroup;
            _CategoryViewModels = new CategoryViewModels();
            _CategorySubGroupModel = new CategorySubGroupModel();
        }

        // GET: Admin
        public ActionResult Index()
        {

            _CategoryGroup.ModelList.DetailsModel = new List<DAL.Master.CategoryViewModels>();
            _CategoryViewModels = new CategoryViewModels();

            return View();
        }

        public PartialViewResult AddCategoryModal()
        {
            return PartialView();
        }

        public ActionResult AddCategoryGroup()
        {
            // _CategoryGroup.ModelList.DetailsModel = new List<DAL.Master.CategoryGroup.CategoryViewModels>();
            _CategoryViewModels = new CategoryViewModels();
            List<CategoryViewModels> list = _CategoryGroup.ShowCategory();
            _CategoryGroup.ModelList.DetailsModel = list;

            DataSet ds = _CategoryGroup.GridReport();
            ViewBag._CategoryList = ds.Tables[0];
            ViewBag.DataList = ds.Tables[0];

            ViewBag._CategoryList2 = list;
            return View();
        }

        public ActionResult AddCategorySubGroup()
        {
            _CategoryViewModels = new CategoryViewModels();
            List<CategoryViewModels> list = _CategoryGroup.ShowCategory();
            _CategoryGroup.ModelList.DetailsModel = list;

            DataSet ds = _CategoryGroup.GridReport();
            ViewBag._CategoryList = ds.Tables[0];

            DataSet dss = _ICategorySubGroup.ShowCategorySubGroup();
            ViewBag._CategorySubGroupList = dss.Tables[0];

            return View();
        }

        public ActionResult saveCategoryGroup(FormCollection frm)
        {
            int categoryId;
            bool parse  = int.TryParse(frm["CategoryId"].ToString(), out categoryId);
            if(parse)
            {
                _CategoryGroup.Model.CategoryId = categoryId;
            }
            _CategoryGroup.Model.Tag = frm["button-text"].ToString();
            _CategoryGroup.Model.CategoryName = frm["CategoryName"].ToString();
            _CategoryGroup.Model.UrlSalg = frm["CategoryName"].ToString();
            
            string categoryImage = frm["CategoryImage"]; // Access the CategoryImage field (e.g., for an image file path or filename)

            // For handling file uploads, you need to use HttpPostedFileBase
            HttpPostedFileBase categoryImageFile = Request.Files["CategoryImage"];  // Use Request.Files to get fil
            // For example, if CategoryImage is a file input, save the file to the server:
            if (categoryImageFile != null && categoryImageFile.ContentLength > 0)
            {
                string fileName = Path.GetFileName(categoryImageFile.FileName);
                _CategoryGroup.Model.CategoryImage = fileName;
                string path = Path.Combine(Server.MapPath("~/UploadedImages"), fileName);
              //  categoryImageFile.SaveAs(path);
            }
            _CategoryGroup.Model.EntryDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            _CategoryGroup.Model.Status = "1";

            if (_CategoryGroup.Model.CategoryId >0)
            {
             
            }
            else {
                _CategoryGroup.Model.Tag = "NEW";
            }
           

            _CategoryGroup.Save();
           List<CategoryViewModels> list = _CategoryGroup.ShowCategory();
            _CategoryGroup.ModelList.DetailsModel = list;
            return RedirectToAction("AddCategoryGroup",list);
        }

        public JsonResult FetchCategoryById2(string id)
        {
            CategoryViewModels value = _CategoryGroup.FetchCategoryById(id);
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public JsonResult FetchSubCategoryById2(string subCategoryId, string categoryId)
        {
            DataSet ds = _CategoryGroup.GridReportById(Convert.ToInt32(categoryId));
            ViewBag._CategoryList = ds.Tables[0];
            CategorySubGroupModel value = _ICategorySubGroup.FetchSubCategoryById(subCategoryId);
            return Json(value, JsonRequestBehavior.AllowGet);
        }


        public ActionResult saveCategorySubGroup(FormCollection frm)
        {
            int SubCategoryId;
            int CategoryId;
            bool parse = int.TryParse(frm["SubCategoryId"].ToString(), out SubCategoryId);
            bool parseCategoryId = int.TryParse(frm["CategoryId"].ToString(), out CategoryId);
            if (parse)
            {
                _ICategorySubGroup.Model.SubCategoryId = SubCategoryId;
            }
            if (parseCategoryId)
            {
                _ICategorySubGroup.Model.CategoryId = CategoryId;
            }
            _ICategorySubGroup.Model.Tag = frm["button-text"].ToString();
            _ICategorySubGroup.Model.SubCategoryName = frm["SubCategoryName"].ToString();
            _ICategorySubGroup.Model.UrlSlug = frm["SubCategoryName"].ToString();

            string categoryImage = frm["SubCategoryImage"]; // Access the CategoryImage field (e.g., for an image file path or filename)

            // For handling file uploads, you need to use HttpPostedFileBase
            HttpPostedFileBase categoryImageFile = Request.Files["SubCategoryImage"];  // Use Request.Files to get fil
            // For example, if CategoryImage is a file input, save the file to the server:
            if (categoryImageFile != null && categoryImageFile.ContentLength > 0)
            {
                string fileName = Path.GetFileName(categoryImageFile.FileName);
                _ICategorySubGroup.Model.SubCategoryImage = fileName;
                string path = Path.Combine(Server.MapPath("~/UploadedImages"), fileName);
                //  categoryImageFile.SaveAs(path);
            }
            _ICategorySubGroup.Model.EntryDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            _ICategorySubGroup.Model.Status = "1";

            if (_ICategorySubGroup.Model.SubCategoryId > 0)
            {

            }
            else
            {
                _ICategorySubGroup.Model.Tag = "NEW";
            }


            _ICategorySubGroup.save();
            DataSet ds = _ICategorySubGroup.ShowCategorySubGroup();
            ViewBag._CategorySubGroupList = ds.Tables[0];
            //  _CategoryGroup.ModelList.DetailsModel = list;
            return RedirectToAction("AddCategorySubGroup");
        }


    }
}