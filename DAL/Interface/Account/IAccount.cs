using DAL.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Account
{
   public interface IAccount
    {
        AccountViewModel Model { get; set; }

        string saveUser();

        AccountViewModel checkUser();

        List<AccountViewModel> getAllUser();
    }
}
