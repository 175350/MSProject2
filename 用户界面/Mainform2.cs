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
    public partial class Mainform2 : Form
    {
        public Mainform2()
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
        private void 学生信息管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("学生信息管理ToolStripMenuItem1"))
            {
                XSXX2 xsxx2 = new XSXX2();
                xsxx2.MdiParent = this;
                xsxx2.Show();
            }
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UILogin ui = new UILogin();
            ui.MdiParent = this;
            ui.Show();
            this.Close();
        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("成绩管理ToolStripMenuItem"))
            {
                CJGL2 cjgl2 = new CJGL2();
                cjgl2.MdiParent = this;
                cjgl2.Show();
            }
        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("课程管理ToolStripMenuItem"))
            {
                KCGL2 kcgl2 = new KCGL2();
                kcgl2.MdiParent = this;
                kcgl2.Show();
            }
        }

        private void 班级信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("班级信息管理ToolStripMenuItem"))
            {
                BJGL2 bjgl2 = new BJGL2();
                bjgl2.MdiParent = this;
                bjgl2.Show();
            }
        }
    }
}
