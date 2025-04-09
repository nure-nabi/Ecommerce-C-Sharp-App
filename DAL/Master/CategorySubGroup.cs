using DAL.Interface.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Master
{
   public class CategorySubGroup : ICategorySubGroup
    {
        ActiveDataAccess.ActiveDataAccess DAL;
        public CategorySubGroupModel Model { get; set; }
        public CategorySubGroup()
        {
            DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
            Model = new CategorySubGroupModel();
        }

       public string save()
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("BEGIN TRANSACTION \n");
            strSql.Append("BEGIN TRY \n");

            if (Model.Tag.ToUpper() == "NEW")
            {
                strSql.Append("Insert into CategorySubGroup(CategoryId,SubCategoryName,UrlSlug,SubCategoryImage,EntryDate,[Status])\n");
                strSql.Append("Select '" + Model.CategoryId + "','" + Model.SubCategoryName + "','" + Model.UrlSlug + "','" + Model.SubCategoryImage + "','" + Model.EntryDate + "','" + Model.Status + "'");
            }
            else if (Model.Tag.ToUpper() == "EDIT")
            {
                strSql.Append("Update CategorySubGroup Set SubCategoryName='" + Model.SubCategoryName + "' Where SubCategoryId='"+Model.SubCategoryId+"'");
            }
            else if (Model.Tag.ToUpper() == "DELETE")
            { 
                strSql.Append("Delete from CategorySubGroup Where SubCategoryId='" + Model.SubCategoryId + "'");
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

        public DataSet ShowCategorySubGroup()
        {
            
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from CategorySubGroup\n");
            return DAL.ExecuteDataset(CommandType.Text, strSql.ToString());
           
        }

        public CategorySubGroupModel FetchSubCategoryById(string id)
        {
            CategoryViewModels CategoryViewModels = new CategoryViewModels();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from CategorySubGroup Where SubCategoryId='" + id + "'\n");
            DataTable dt = DAL.ExecuteDataset(CommandType.Text, strSql.ToString()).Tables[0];
            CategorySubGroupModel rec = null;
            if (dt.Rows.Count > 0)
            {
                rec = new CategorySubGroupModel
                {
                    SubCategoryName = (dt.Rows[0]["SubCategoryName"].ToString()),
                    SubCategoryImage = (dt.Rows[0]["SubCategoryImage"].ToString()),
                    SubCategoryId = Convert.ToInt32(dt.Rows[0]["SubCategoryId"]),
                    CategoryId = Convert.ToInt32(dt.Rows[0]["CategoryId"])
                };
                return rec;
            }
            else
            {
                return rec;
            }


        }

        public DataSet ShowCategorySubGroupById(int categoryId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from CategorySubGroup Where CategoryId='" + categoryId + "'\n");
            return DAL.ExecuteDataset(CommandType.Text, strSql.ToString());
        }
    }

    public class CategorySubGroupModel {

        public string Tag { get; set; }
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string UrlSlug { get; set; }
        public string SubCategoryImage { get; set; }
        public string EntryDate { get; set; }
        public string Status { get; set; }
    }
}
