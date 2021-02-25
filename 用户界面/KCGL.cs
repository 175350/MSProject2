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
    public partial class KCGL : Form
    {
        public static KCGL kc;
        public KCGL()
        {
            InitializeComponent();
            kc = this;
        }

        public void dataup()
        {

            DataSet da = BLL.BLLKCInfo.select("");
            dataGridView1.DataSource = da.Tables[0];

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("KCGLZG"))
            {
                KCGLZG kc= new KCGLZG();
                kc.status = "添加";
                kc.MdiParent = this.MdiParent;
                dataup();
                kc.Show();
            }
        }

        private void KCGL_Load(object sender, EventArgs e)
        {
            dataup();
            //dataGridView1.Columns[2].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("KCGLZG"))
            {
                KCGLZG kc= new KCGLZG();
                kc.status = "修改";
                kc.classID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                kc.MdiParent = this.MdiParent;
                dataup();
                kc.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        int id = int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                        BLL.BLLKCInfo.delete(id);
                    }
                    MessageBox.Show("删除成功！");
                    dataup();
                    return;
                }
                MessageBox.Show("删除失败！");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataup();
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
            else if (comboBox1.Text == "课程名称")
            {
                string kcmc = textBox1.Text;
                string sql = "课程名称 like '%" + kcmc + "%'";
                DataSet ds = BLL.BLLKCInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox1.Text == "班级ID")
            {
                string bjid = textBox1.Text;
                string sql = "班级ID like '%" + bjid + "%'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
