using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Administrator
    {
        public string 用户名;
        public string 密码;
        public string 身份;

        public string 身份1
        {
            get { return 身份; }
            set { 身份 = value; }
        }

        public string 用户名1
        {
            get { return 用户名; }
            set { 用户名 = value; }
        }
        

        public string 密码1
        {
            get { return 密码; }
            set { 密码 = value; }
        }

       
    }
}
