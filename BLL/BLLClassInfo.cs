using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
   public class BLLClassInfo
    {
        public static bool add(Model.ClassInfo bj)
        {
            return DAL.DALClassInfo.add(bj);
        }
        public static DataSet select(string strwhere)
        {
            return DAL.DALClassInfo.select(strwhere);
        }
        public static bool modify(Model.ClassInfo bj, string classID)
        {
            return DAL.DALClassInfo.modify(bj,classID);
        }
        public static bool delete(int id)
        {
            return DAL.DALClassInfo.delete(id);
        }
    }
}
