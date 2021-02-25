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
    public partial class KCGL2 : Form
    {
        public static KCGL2 kcgl2;

        public KCGL2()
        {
            InitializeComponent();
            kcgl2 = this;
        }

        public void dataup()
        {

            DataSet da = BLL.BLLKCInfo.select("");
            dataGridView1.DataSource = da.Tables[0];

        }

        private void KCGL2_Load(object sender, EventArgs e)
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
                DataSet ds = BLL.BLLKCInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.Text == "班级ID")
            {
                string id = textBox1.Text;
                string sql = "班级ID like '%" + id + "%'";
                DataSet ds = BLL.BLLKCInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.Text == "课程名称")
            {
                string 课程名称 = textBox1.Text;
                string sql = "课程名称 like '%" + 课程名称 + "%'";
                DataSet ds = BLL.BLLKCInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string kslx = textBox1.Text;
                string sql = "考试类型 like '%" + kslx + "%'";
                DataSet ds = BLL.BLLKCInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataup();
        }
    }
}
