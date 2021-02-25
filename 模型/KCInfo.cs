using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class KCInfo
    {
       public string 课程ID;
       public string 考试类型;
       public string 课程名称;
       public string 班级ID;

        public string 课程ID1
        {
            get { return 课程ID; }
            set { 课程ID = value; }
        }
        

        public string 课程名称1
        {
            get { return 课程名称; }
            set { 课程名称 = value; }
        }
        

        public string 班级ID1
        {
            get { return 班级ID; }
            set { 班级ID = value; }
        }
        

        public string 考试类型1
        {
            get { return 考试类型; }
            set { 考试类型 = value; }
        }
    }
}
