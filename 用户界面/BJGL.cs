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
    public partial class BJGL : Form
    {
        public static BJGL bjgl;
        public BJGL()
        {
            InitializeComponent();
            bjgl = this;
        }

        public void dataup()
        {

            DataSet da = BLL.BLLClassInfo.select("");
            dataGridView1.DataSource = da.Tables[0];

        } 

        private void BJGL_Load(object sender, EventArgs e)
        {
            dataup();
            //dataGridView1.Columns[0].Visible=true;
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
            if (!IsMdiChildrenInstance("BJBLZG"))
            {
                BJBLZG bj = new BJBLZG();
                bj.status = "添加";
                bj.MdiParent = this.MdiParent;
                dataup();
                bj.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsMdiChildrenInstance("BJBLZG"))
            {
                BJBLZG bj = new BJBLZG();
                bj.status = "修改";
                bj.classID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bj.MdiParent = this.MdiParent;
                dataup();
                bj.Show();
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
                        BLL.BLLClassInfo.delete(id);
                    }
                    MessageBox.Show("删除成功！");
                    dataup();
                    return;
                }
                MessageBox.Show("删除失败！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string sql = "班级名称 like '%" + name + "%'";
            DataSet ds = BLL.BLLClassInfo.select(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataup();
        }

    }
}
