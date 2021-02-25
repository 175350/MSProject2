using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
   public class BLLStudentCJ
   {
       public static DataSet select(string strwhere)
       {
           return DAL.DALStudentCJ.select(strwhere);
       }
    }
}
