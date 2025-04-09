using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveDataAccess;
using DAL.Interface;
using DAL.Interface.Master;

namespace DAL.Master
{


    public class CategoryGroup : ICategoryGroup
    {
        ActiveDataAccess.ActiveDataAccess DAL;
        public CategoryViewModels Model { get; set; }

        
       public  CategoryViewModelsList ModelList { get; set; }

        public CategoryGroup()
        {
            DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
            Model = new CategoryViewModels();
           ModelList = new CategoryViewModelsList();
        }

        public string Save()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("BEGIN TRANSACTION \n");
            strSql.Append("BEGIN TRY \n");

            if (Model.Tag.ToUpper() == "NEW")
            {
                strSql.Append("Insert into CategoryGroup([CategoryName],[UrlSlug],CategoryImage,EntryDate,Status) \n");
                strSql.Append("select '" + Model.CategoryName.Trim() + "','" + Model.UrlSalg.Trim() + "','" + Model.CategoryImage.Trim() + "','" + Model.EntryDate.Trim() + "','" + Model.Status.Trim() + "' ");

            }
            else if (Model.Tag.ToUpper() == "EDIT")
            {
                strSql.Append("UPDATE CategoryGroup SET [CategoryName]='" + Model.CategoryName.Trim() + "',EntryDate='" + Model.EntryDate.Trim() + "' Where CategoryId='"+Model.CategoryId+"'");
            }
            else if (Model.Tag.ToUpper() == "DELETE")
            {
                strSql.Append("Delete from CategoryGroup Where CategoryId='" + Model.CategoryId + "'");
            }

            strSql.Append("\n COMMIT TRANSACTION \n");
            strSql.Append("END TRY \n");
            strSql.Append("BEGIN CATCH \n");
            strSql.Append("ROLLBACK TRANSACTION \n");
            strSql.Append("END CATCH \n");

            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@VNo", SqlDbType.VarChar, 25);
            p[0].Direction = ParameterDirection.Output;
            DAL.ExecuteNonQuery(CommandType.Text, strSql.ToString(), p);
            return p[0].Value.ToString();
        }

        public List<CategoryViewModels> ShowCategory()
        {

            List<CategoryViewModels> CategoryViewList = new List<CategoryViewModels>();

            StringBuilder strSql = new StringBuilder();

            strSql.Append("Select * from CategoryGroup\n");
            using (DataSet ds = DAL.ExecuteDataset(CommandType.Text, strSql.ToString()))
            {
                using (DataTable dt = ds.Tables[0])
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        CategoryViewList.Add(new CategoryViewModels()
                        {
                            CategoryName = dr["CategoryName"].ToString(),
                            CategoryImage = dr["CategoryImage"].ToString(),
                            Status = dr["Status"].ToString(),
                        }
                        );

                    }
                }
            }
            return CategoryViewList;
        }

        public DataSet GridReport()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from CategoryGroup\n");

            return DAL.ExecuteDataset(CommandType.Text, strSql.ToString());
        }

        public DataSet GridReportById(int categoryId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from CategoryGroup Where CategoryId='"+categoryId+"'\n");

            return DAL.ExecuteDataset(CommandType.Text, strSql.ToString());
        }

        public CategoryViewModels FetchCategoryById(string id)
        {
            CategoryViewModels CategoryViewModels = new CategoryViewModels();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from CategoryGroup Where CategoryId='"+id+"'\n");


            DataTable dt = DAL.ExecuteDataset(CommandType.Text, strSql.ToString()).Tables[0];
            CategoryViewModels rec= null ;
            if (dt.Rows.Count > 0)
            {
                rec = new CategoryViewModels
                {
                    CategoryName = (dt.Rows[0]["CategoryName"].ToString()),
                    CategoryImage = (dt.Rows[0]["CategoryImage"].ToString()),
                };
                return rec;
            }
            else {
                return rec;
            }

    
        }

       
    }

    public class CategoryViewModelsList
    {
        public List<CategoryViewModels> DetailsModel { get; set; }
    }

    public class CategoryViewModels
    {

        public string Tag { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string UrlSalg { get; set; }
        public string CategoryImage { get; set; }
        public string EntryDate { get; set; }
        public string Status { get; set; }


    }
}
