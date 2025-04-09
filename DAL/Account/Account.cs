
using DAL.Interface.Account;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Account
{
   public class Account : IAccount
    {
        ActiveDataAccess.ActiveDataAccess DAL;
        public AccountViewModel Model { get; set; }
        public Account()
        {
            DAL = new ActiveDataAccess.ActiveDataAccess(Database.DBConnection);
            Model = new AccountViewModel();
        }

        public string saveUser()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("BEGIN TRANSACTION\n");
            strSql.Append("BEGIN TRY\n");
            strSql.Append("Insert into Users(UserName,MobileNo,Email,[Address],City,[State],Pincode,[Password])\n");
            strSql.Append("select '" + Model.UserName.Trim() + "','" + Model.MobileNo.Trim() + "','" + Model.Email.Trim() + "','" + Model.Address.Trim() + "', '" + Model.City.Trim() + "','" + Model.State.Trim() + "','" + Model.Pincode.Trim() + "','" + Model.Password.Trim() + "'\n");

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

        public AccountViewModel checkUser()
        {
            StringBuilder strSql = new StringBuilder();
            AccountViewModel model = new AccountViewModel();
            strSql.Append("Select * from Users Where UserName = '"+Model.UserName+"' AND [Password] = '"+Model.Password+"'\n");

            using (DataTable dt = DAL.ExecuteDataset(CommandType.Text, strSql.ToString()).Tables[0])
            {
                if (dt.Rows.Count > 0)
                {
                   model.UserId = Convert.ToInt64(dt.Rows[0]["userId"].ToString());
                   model.UserName = dt.Rows[0]["UserName"].ToString();
                   model.MobileNo = dt.Rows[0]["MobileNo"].ToString();
                   model.Email = dt.Rows[0]["Email"].ToString();
                    model.Address = dt.Rows[0]["Address"].ToString();
                  
                }
            }
            return model;

        }

        public List<AccountViewModel> getAllUser()
        {
            throw new NotImplementedException();
        }
    }

    public class AccountViewModel
    { 
       public Int64 UserId { get; set; }
       public string UserName { get; set; }
       public string MobileNo { get; set; }
       public string Email { get; set; }
       public string Address { get; set; }
       public string City { get; set; }
       public string State { get; set; }
       public string Pincode { get; set; }
       public string Password { get; set; }
        public string Cnf_Password { get; set; }

    }
}
