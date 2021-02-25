using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
   public class BLLStudentMagement
   {
       public static DataSet select(string strwhere)
       {
           return DAL.DALStudentMagement.select(strwhere);
       }
    }
}
