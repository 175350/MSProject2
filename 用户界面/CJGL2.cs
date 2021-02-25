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
    public partial class CJGL2 : Form
    {
           public static CJGL2 cjgl2;

        public CJGL2()
        {
            InitializeComponent();
            cjgl2 = this;
        }

        public void dataup()
        {

            DataSet da = BLL.BLLCJInfo.select("");
            dataGridView1.DataSource = da.Tables[0];

        }

        private void CJGL2_Load(object sender, EventArgs e)
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
            if (comboBox1.Text == "课程ID")
            {
                string name = textBox1.Text;
                string sql = "课程ID like '%" + name + "%'";
                DataSet ds = BLL.BLLCJInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.Text == "学号")
            {
                string id = textBox1.Text;
                string sql = "学号 like '%" + id + "%'";
                DataSet ds = BLL.BLLCJInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.Text == "课程名称")
            {
                string 课程名称 = textBox1.Text;
                string sql = "课程名称 like '%" + 课程名称 + "%'";
                DataSet ds = BLL.BLLCJInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string 成绩 = textBox1.Text;
                string sql = "成绩 like '%" + 成绩 + "%'";
                DataSet ds = BLL.BLLCJInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataup();
        }
    }
}
