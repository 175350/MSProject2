using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class BLLAdministrator
    {
        public static DataSet select(string strwhere)
        {
            return DAL.DALAdministrator.select(strwhere);
        }
        public static bool add(Model.Administrator yh)
        {
            return DAL.DALAdministrator.add(yh);
        }
        public static bool modify(Model.Administrator xg)
        {
            return DAL.DALAdministrator.modify(xg);
        }
    }
}
