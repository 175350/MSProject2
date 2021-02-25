using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class DALStudentCJ
    {
        public static DataSet select(string strwhere)
        {
            string sql = "select * from 学生成绩";
            if (strwhere != "")
            {
                sql = sql + " where " + strwhere;
            }
            return DBUtinity.SQLHelp.Query(sql);
        }
    }
}
