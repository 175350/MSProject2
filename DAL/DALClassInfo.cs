using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class DALClassInfo
    {
        public static bool add(Model.ClassInfo bj)
        {
            string sql = "insert into ClassInfo values('" + bj.班级ID + "','" + bj.班级名称 + "')";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static DataSet select(string strwhere)
        {
            string sql = "select * from ClassInfo";
            if (strwhere != "")
            {
                sql = sql + " where " + strwhere;
            }
            return DBUtinity.SQLHelp.Query(sql);
        }

        public static bool modify(Model.ClassInfo bj, string classID)   /*修改*/
        {
            string sql = "update ClassInfo set  班级名称='" + bj.班级名称 + "' where 班级ID='" + classID + "'";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static bool delete(int id)
        {
            string sql = "delete from ClassInfo where 班级ID='" + id + "'";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
    }
}
