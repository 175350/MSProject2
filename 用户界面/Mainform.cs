using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace UI
{
    public partial class Mainform : Form
    {
        public Mainform()
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
                XSXX xsxx = new XSXX();
                xsxx.MdiParent = this;
                xsxx.Show();
            }

        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("成绩管理ToolStripMenuItem"))
            {
                CJGL1 cjgl = new CJGL1();
                cjgl.MdiParent = this;
                cjgl.Show();
                
            }
        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("课程管理ToolStripMenuItem"))
            {
                KCGL kcgl = new KCGL();
                kcgl.MdiParent = this;                
                kcgl.Show();
                
            }
        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.ExitThread();
            Application.Exit();
            Thread temp = new Thread(run);
            object appname = Application.ExecutablePath;
            Thread.Sleep(1);
            temp.Start(appname);

            //SQLLogen ui = new SQLLogen();
            //ui.MdiParent = this;
            //ui.Show();
            //this.Close();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("添加用户ToolStripMenuItem"))
            {
                TJYHXX tjyhxx = new TJYHXX();
                tjyhxx.MdiParent = this;
                tjyhxx.Show();
            }
        }

        private void 班级信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("班级信息管理ToolStripMenuItem"))
            {
                BJGL bjgl = new BJGL();
                bjgl.MdiParent = this;
                bjgl.Show();
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("修改密码ToolStripMenuItem"))
            {
                XGMM xgmm = new XGMM();
                xgmm.MdiParent = this;
                xgmm.Show();
            }
        }
        private void run(object obj)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }
    }
}
