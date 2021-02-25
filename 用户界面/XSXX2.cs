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
    public partial class XSXX2 : Form
    {
        public XSXX2()
        {
            InitializeComponent();
        }

        public void dataup()
        {

            DataSet da = BLL.BLLStudentInfo.select("");
            dataGridView1.DataSource = da.Tables[0];

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "姓名")
            {
                string name = textBox2.Text;
                string sql = "姓名 like '%" + name + "%'";
                DataSet ds = BLL.BLLStudentInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.Text == "学号")
            {
                string id = textBox2.Text;
                string sql = "学号 like '%" + id + "%'";
                DataSet ds = BLL.BLLStudentInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string 班级id = textBox2.Text;
                string sql = "班级ID like '%" + 班级id + "%'";
                DataSet ds = BLL.BLLStudentInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataup();
        }

        private void XSXX2_Load(object sender, EventArgs e)
        {
            dataup();
            //dataGridView1.Columns[2].Visible = false;
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

    }
}
