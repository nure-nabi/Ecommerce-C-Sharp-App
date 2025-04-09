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
  public  class Size : ISize
    {
        ActiveDataAccess.ActiveDataAccess DAL;
        public SizeViewModels Model { get; set; }

        public Size()
        {
            DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
            Model = new SizeViewModels();
        }

        public string save()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("BEGIN TRANSACTION \n");
            strSql.Append("BEGIN TRY \n");
            if (Model.Tag.ToUpper() == "NEW")
            {
                strSql.Append("Insert into Size(SizeName,BrandSize,ToFit,EntryDate)\n");
                strSql.Append("select '"+Model.SizeName.Trim()+ "','" + Model.BrandSize.Trim() + "','" + Model.ToFit.Trim() + "','" + Model.EntryDate + "'\n");
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

        public DataSet showSize()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select * from Size");

            return DAL.ExecuteDataset(CommandType.Text, strSql.ToString());

        }
    }

   

    public class SizeViewModels
    {
        public string Tag { get; set; }
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public string BrandSize { get; set; }
        public string ToFit { get; set; }
        public string EntryDate { get; set; }

    }
}
