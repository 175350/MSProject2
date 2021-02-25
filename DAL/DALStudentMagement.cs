using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
   public class DALStudentMagement
   {
       public static DataSet select(string strwhere)
       {
           string sql = "select * from 学生个人信息";
           if (strwhere != "")
           {
               sql = sql + " where " + strwhere;
           }
           return DBUtinity.SQLHelp.Query(sql);
       }
    }
}
