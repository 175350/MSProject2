using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
   public class BLLCJInfo
    {
        public static bool add(Model.CJInfo cj)
        {
            return DAL.DALCJInfo.add(cj);
        }
        public static DataSet select(string strwhere)
        {
            return DAL.DALCJInfo.select(strwhere);
        }
        public static bool modify(Model.CJInfo cj,string studentID)
        {
            return DAL.DALCJInfo.modify(cj, studentID);
        }
        public static bool delete(int id)
        {
            return DAL.DALCJInfo.delete(id);
        }
    }
}
