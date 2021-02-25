using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
   public class BLLKCInfo
    {
        public static bool add(Model.KCInfo kc)
        {
            return DAL.DALKCInfo.add(kc);
        }
        public static DataSet select(string strwhere)
        {
            return DAL.DALKCInfo.select(strwhere);
        }
        public static bool modify(Model.KCInfo kc,string classID)
        {
            return DAL.DALKCInfo.modify(kc,classID);
        }
        public static bool delete(int id)
        {
            return DAL.DALKCInfo.delete(id);
        }
    }
}
