using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Master;


namespace DAL.Interface
{
  public  interface ICategoryGroup
    {
        CategoryViewModels Model { get; set; }
        CategoryViewModelsList ModelList { get; set; }
        string Save();

        List<CategoryViewModels> ShowCategory();
        DataSet GridReport();

        DataSet GridReportById(int categoryId);

        CategoryViewModels FetchCategoryById(String id);

    }
}
