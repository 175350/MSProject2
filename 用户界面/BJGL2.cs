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
    public partial class BJGL2 : Form
    {
        public static BJGL2 bjgl2;

        public BJGL2()
        {
            InitializeComponent();
            bjgl2 = this;
        }

        public void dataup()
        {

            DataSet da = BLL.BLLClassInfo.select("");
            dataGridView1.DataSource = da.Tables[0];

        }

        private void BJGL2_Load(object sender, EventArgs e)
        {
            dataup();
            dataGridView1.Columns[2].Visible = false;
        }

        public bool IsMdiChildrenInstance(string MdiChildrenName)
        {
            foreach (Form childfrm in this.MdiParent.MdiChildren)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "班级ID")
            {
                string name = textBox1.Text;
                string sql = "班级ID like '%" + name + "%'";
                DataSet ds = BLL.BLLClassInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string 班级名称 = textBox1.Text;
                string sql = "班级名称 like '%" + 班级名称 + "%'";
                DataSet ds = BLL.BLLClassInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
