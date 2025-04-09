using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public static class Database
    {
        public static string DBConnection
        {
            get { return "Data Source=" + ServerDetails.uServerName + "; User ID=" + ServerDetails.uServerUserName + "; Password=" + ServerDetails.uServerPassword + "; Persist Security Info=True; Initial Catalog=" + ServerDetails.uCompDatabaseName + "; Max Pool Size=100; "; }
            // get { return "Data Source=" + ServerDetails.uServerName + "; User ID=" + HttpContext.Current.Session["ServerUserName"] + "; Password=" + HttpContext.Current.Session["ServerPassword"] + "; Persist Security Info=True; Initial Catalog=" + HttpContext.Current.Session["CompDatabaseName"] + "; Max Pool Size=100;"; }
        }

        public static string DBCon
        {
            //get { return "Data Source=" + ServerDetails.uServerName + "; User ID=" + ServerDetails.uServerUserName + "; Password=" + ServerDetails.uServerPassword + "; Persist Security Info=True; Initial Catalog=" + ServerDetails.uCompDatabaseName + "; Max Pool Size=100; "; }
            //get { return "Data Source=" + GlobalSessionCls._ServerName + "; User ID=" + GlobalSessionCls._ServerUserName + "; Password=" + GlobalSessionCls._ServerPassword + "; Persist Security Info=True; Initial Catalog=" + GlobalSessionCls._CompDatabaseName + "; Max Pool Size=100;"; }
            get { return "asd"; }
        }
        public static SqlConnection Connection()
        {
          //  string constring = "data source=" + GlobalSessionCls._ServerName + "; Initial Catalog=" + GlobalSessionCls._CompDatabaseName + "; User Id=" + GlobalSessionCls._ServerUserName + "; pwd=" + GlobalSessionCls._ServerPassword + "; Integrated Security=false;pooling=false;connection lifetime=15000;";
            SqlConnection Con = new SqlConnection("");
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
            Con.Open();

            return Con;
        }
        public static SqlConnection MasterConnection()
        {

           // string constring = @"Data Source=" + GlobalSessionCls._ServerName + ";Initial Catalog=PMS;Persist Security Info=True;User ID=" + GlobalSessionCls._ServerUserName + ";Password=" + GlobalSessionCls._ServerPassword + ";Connection Timeout=1000";
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = "";
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
            Con.Open();
            return Con;
        }
        public static string RollBackCon()
        {
            try
            {
               // string con1 = "data source=" + GlobalSessionCls._ServerName + "; Initial Catalog=" + GlobalSessionCls._CompDatabaseName + "; User Id=" + GlobalSessionCls._ServerUserName + "; pwd=" + GlobalSessionCls._ServerPassword + "; Integrated Security=false";
                return "";
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);

            }
        }
        public static bool ConnectionCheck(string sname, string suname, string spass)
        {
            try
            {
                string constr = @"Data Source=" + sname + ";Initial Catalog=PMS;Persist Security Info=True;User ID=" + suname + ";Password=" + spass + "";
                SqlConnection Con = new SqlConnection(constr);
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                if (Con.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static DataTable FetchingMasterData(string Sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(Sql, MasterConnection());
            cmd.CommandTimeout = 500;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
        public static DataTable FetchingData(string Sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(Sql, Connection());
            cmd.CommandTimeout = 500;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
        public static DataSet SqlDataSet(string Query)
        {
            var sda = new SqlDataAdapter(Query, Connection());
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public static string GetSqlData(string Sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(Sql, Connection());
                cmd.CommandTimeout = 500;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static string GetSqlMasterData(string Sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(Sql, MasterConnection());
                cmd.CommandTimeout = 500;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static bool ExecuteNonQuery(string sqlStatement)
        {
            try
            {
                //SqlConnection con = new SqlConnection();           
                //con.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, Connection());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                //con.Close();
                //con.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                string Msg = ex.Message;
                //throw new ArgumentException(ex.Message);
                return false;
            }
        }
        public static string ExecuteQuery(string sqlStatement)
        {
            try
            {
                //SqlConnection con = new SqlConnection();
                //con.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, Connection());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                cmd.Dispose();

                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string Val(string Value)
        {
            if (Value == "")
                Value = "0";
            return Value;
        }
        //public static DataSet GetDataSet(string sql)
        //{
        //    if (string.IsNullOrEmpty(ClsGlobal.uCompDatabaseName)) ClsGlobal.uCompDatabaseName = "PMS";
        //    ActiveDataAccess.ActiveDataAccess DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
        //    return DAL.ExecuteDataset(CommandType.Text, sql);
        //}

        //public static DataTable GetDataTable(string sql)
        //{
        //    if (string.IsNullOrEmpty(ClsGlobal.uCompDatabaseName)) ClsGlobal.uCompDatabaseName = "PMS";
        //    ActiveDataAccess.ActiveDataAccess DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
        //    return DAL.ExecuteDataset(CommandType.Text, sql).Tables[0];
        //}

        //public static string GetSingleVal(string sql)
        //{
        //    if (string.IsNullOrEmpty(ClsGlobal.uCompDatabaseName)) ClsGlobal.uCompDatabaseName = "PMS";
        //    ActiveDataAccess.ActiveDataAccess DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
        //    string val = "";
        //    DataTable dt = DAL.ExecuteDataset(CommandType.Text, sql).Tables[0];
        //    foreach (DataRow ro in dt.Rows)
        //    {
        //        if (dt.Rows.Count > 0)
        //        {
        //            val = ro[0].ToString();
        //        }
        //    }
        //    return val;
        //}
        //public static void ExecuteNonQuery(string sql)
        //{
        //    if (string.IsNullOrEmpty(ClsGlobal.uCompDatabaseName)) ClsGlobal.uCompDatabaseName = "PMS";
        //    ActiveDataAccess.ActiveDataAccess DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
        //    DAL.ExecuteNonQuery(CommandType.Text, sql);
        //}
    }

    public static class ServerDetails
    {
        // public static string physicalWebRootPath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/ServerConnection.txt");
        // public static string[] fileContents = System.IO.File.ReadAllLines(physicalWebRootPath);

        //public static string[] fileContents = System.IO.File.ReadAllLines(@"H:\\OmsAccOnline\\API\\bin\\Release\\PublishOutput\\App_Data\\ServerConnection.txt");
        //////--------- PRODUCTION PC
        //public static string uServerName = "Database";
        //public static string uServerUserName = "SA";
        //public static string uServerPassword = "Nepal12#";
        //public static string uCompDatabaseName = "PMS";

        ////--------- DEMO PC
        public static string uServerName = "RND-6";
        public static string uServerUserName = "SA";
        public static string uServerPassword = "oms@123";
        public static string uCompDatabaseName = "Ecomerce";

        //--------- SANTOSH PC

        //public static string fileContentsw = System.IO.File.ReadAllText(physicalWebRootPath);
        //public static string[] lines = fileContentsw.Split("\n"[0]);

        //public static string uServerName = lines[0].ToString().Trim(); //fileContents[0].ToString();
        //public static string uServerUserName = lines[1].ToString().Trim(); //fileContents[1].ToString();
        //public static string uServerPassword = lines[2].ToString().Trim(); //fileContents[2].ToString();
        //public static string uCompDatabaseName = "PMS";
    }
}
