using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Mainform1 : Form
    {
        public Mainform1()
        {
            InitializeComponent();
        }
        public bool IsMdiChildrenInstance(string MdiChildrenName)
        {
            foreach (Form childfrm in this.MdiChildren)
            {
                if (childfrm.Name == MdiChildrenName)
                {
                    if (childfrm.WindowState == FormWindowState.Minimized)
                    {
                        childfrm.WindowState = FormWindowState.Normal;
                    }
                    childfrm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("个人信息ToolStripMenuItem"))
            {
                XSGRXX xsgrxx = new XSGRXX();
                xsgrxx.MdiParent = this;
                xsgrxx.Show();
            }
        }

        private void 成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("成绩ToolStripMenuItem"))
            {
                XSGRXXCJ xsgrxxcj = new XSGRXXCJ();
                xsgrxxcj.MdiParent = this;
                xsgrxxcj.Show();
            }
        }
    }
}
