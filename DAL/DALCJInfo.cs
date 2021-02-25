using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class DALCJInfo
    {
        public static bool add(Model.CJInfo cj)
        {
            string sql = "insert into CJInfo values('" + cj.学号 + "','" + cj.课程名称 + "','" + cj.课程ID + "','" + cj.成绩 + "')";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static DataSet select(string strwhere)
        {
            string sql = "select * from CJInfo";
            if (strwhere != "")
            {
                sql = sql + " where " + strwhere;
            }
            return DBUtinity.SQLHelp.Query(sql);
        }

        public static bool modify(Model.CJInfo cj, string studentID)   /*修改*/
        {
            string sql = "update CJInfo set 课程ID='" + cj.课程ID + "',成绩='" + cj.成绩 + "',课程名称='" + cj.课程名称 + "' where 学号='" + studentID + "'";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static bool delete(int id)
        {
            string sql = "delete from CJInfo where 学号='"+id+"'";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
    }
}
