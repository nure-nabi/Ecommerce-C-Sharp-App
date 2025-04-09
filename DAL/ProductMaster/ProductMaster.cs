using DAL.Interface.ProductMaster;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProductMaster
{
  public  class ProductMaster : IProductMaster
    {
        ActiveDataAccess.ActiveDataAccess DAL;
        public ProductViewModels Model { get; set; }
        public ProductMaster()
        {
            DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
            Model = new ProductViewModels();
        }

        public string saveProduct()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("BEGIN TRANSACTION \n");
            strSql.Append("BEGIN TRY \n");

            if (Model.Tag.ToUpper() == "NEW")
            {
                strSql.Append("Insert into Product(ProductName,ProductNameNepali,Brand,CategoryId,SubCategoryId,SellerId,Description,Highlights,what_is_in_box,Price,SaleQuantity,is_active_flash_sale)\n");
                strSql.Append("select '" + Model.ProductName + "','" + Model.ProductNameNepali + "','" + Model.Brand + "','" + Model.CategoryId + "','" + Model.SubCategoryId + "','" + Model.SellerId + "','" + Model.Description + "','" + Model.Highlights + "','" + Model.what_is_in_box + "','" + Model.Price + "','" + Model.Qty + "','" + Model.is_active_flash_sale + "'");
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

        public DataSet getProduct()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from Product");
            return DAL.ExecuteDataset(CommandType.Text, strSql.ToString());
        }
    }

    public class ProductViewModels 
    { 
        public string Tag { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductNameNepali { get; set; }
        public string Brand { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int SubCategoryId2 { get; set; }
        public int SellerId { get; set; }
        public string Description { get; set; }
        public string Highlights { get; set; }
        public string what_is_in_box { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public bool is_active_flash_sale { get; set; }
    }


}
