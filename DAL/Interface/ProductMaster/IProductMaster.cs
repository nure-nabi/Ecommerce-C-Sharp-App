using DAL.ProductMaster;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.ProductMaster
{
   public interface IProductMaster
    {
        ProductViewModels Model { get; set; }

        string saveProduct();

        DataSet getProduct();
    }
}
