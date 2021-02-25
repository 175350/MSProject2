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
    public partial class CJGL1 : Form
    {
        public static CJGL1 cjgl;
        public CJGL1()
        {
            InitializeComponent();
            cjgl = this;
        }

        public void dataup()
        {

            DataSet da = BLL.BLLCJInfo.select("");
            dataGridView1.DataSource = da.Tables[0];

        }

        private void CJGL1_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("CJBLZG"))
            {
                CJBLZG cjgl = new CJBLZG();
                cjgl.status = "添加";
                cjgl.MdiParent = this.MdiParent;
                dataup();
                cjgl.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataup();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("CJBLZG"))
            {
                CJBLZG cjgl = new CJBLZG();
                cjgl.status = "修改";
                cjgl.studentID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cjgl.MdiParent = this.MdiParent;
                dataup();
                cjgl.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        int id = int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                        BLL.BLLCJInfo.delete(id);
                    }
                    MessageBox.Show("删除成功！");
                    dataup();
                    return;
                }
                MessageBox.Show("删除失败！");
            }
        }
    }
}
