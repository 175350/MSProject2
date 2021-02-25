using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class DALKCInfo
    {
        public static bool add(Model.KCInfo kc)
        {
            string sql = "insert into KCInfo values('" + kc.课程ID + "','" + kc.课程名称 + "','" + kc.班级ID + "','" + kc.考试类型 + "')";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static DataSet select(string strwhere)
        {
            string sql = "select * from KCInfo";
            if (strwhere != "")
            {
                sql = sql + " where " + strwhere;
            }
            return DBUtinity.SQLHelp.Query(sql);
        }

        public static bool modify(Model.KCInfo kc, string classID)   /*修改*/
        {
            string sql = "update KCInfo set 课程ID='" + kc.课程ID + "',课程名称='" + kc.课程名称 + "',考试类型='" + kc.考试类型 + "' where 班级ID='" + classID + "'";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static bool delete(int id)
        {
            string sql = "delete from KCInfo where 班级ID='"+id+"'";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
    }
}
