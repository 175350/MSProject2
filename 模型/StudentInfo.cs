using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class StudentInfo
    {
        public string XH;
        public string BJID;
        public string MM;
        public string XM;

        public string XM1
        {
            get { return XM; }
            set { XM = value; }
        }
        
        public string MM1
        {
            get { return MM; }
            set { MM = value; }
        }
        
        public string BJID1
        {
            get { return BJID; }
            set { BJID = value; }
        }

        public string XH1
        {
            get { return XH; }
            set { XH = value; }
        }
    }
}
