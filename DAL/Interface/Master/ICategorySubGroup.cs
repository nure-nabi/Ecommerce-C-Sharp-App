using DAL.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Master
{
 public   interface ICategorySubGroup
    {

        CategorySubGroupModel Model { get; set; }
        string save();
        DataSet ShowCategorySubGroup();

        DataSet ShowCategorySubGroupById(int categoryId);
        CategorySubGroupModel FetchSubCategoryById(String id);
    }
}
