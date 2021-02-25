using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
   public class BLLStudentInfo
    {

           public static bool add(Model.StudentInfo stu)
           {
               return DAL.DALStudentInfo.add(stu);
           }
           public static DataSet select(string strwhere)
           {
               return DAL.DALStudentInfo.select(strwhere);
           }
           public static bool modify(Model.StudentInfo stu, string studentID)
           {
               return DAL.DALStudentInfo.modify(stu, studentID);
           }
           public static bool delete(int id)
           {
               return DAL.DALStudentInfo.delete(id);
           }
       }
    
}
