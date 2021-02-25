using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace DAL
{
   public class DALStudentInfo
    {
        public static bool add(Model.StudentInfo stu)
        {
            string sql = "insert into StudentInfo values('" + stu.XH + "','" + stu.XM + "','" + stu.MM + "','" + stu.BJID + "')";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static DataSet select(string strwhere)
        {
            string sql = "select * from StudentInfo";
            if (strwhere != "")
            {
                sql = sql + " where " + strwhere;
            }
            return DBUtinity.SQLHelp.Query(sql);
        }

        public static bool modify(Model.StudentInfo stu, string studentID)   /*修改*/
        {
            string sql = "update StudentInfo set 姓名='" + stu.XM + "',密码='" + stu.MM + "',班级ID='" + stu.BJID + "' where 学号='" + studentID + "'";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static bool delete(int id)
        {
            string sql = "delete from StudentInfo where 学号='"+id+"' ";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
    }
}
