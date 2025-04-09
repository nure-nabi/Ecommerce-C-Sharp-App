using DAL.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.Master
{
  public  interface ISize
    {
        SizeViewModels Model { get; set; }
       string save();

        DataSet showSize();
    }
}
