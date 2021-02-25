using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI
{
    public partial class XSXX : Form
    {

        public static XSXX xsxx;
        public XSXX()
        {
            InitializeComponent();
            xsxx = this;
        }

        public void dataup()
        {

            DataSet da = BLL.BLLStudentInfo.select("");
            dataGridView1.DataSource = da.Tables[0];

        }

        private void XSXX_Load(object sender, EventArgs e)
        {
            dataup();
            //dataGridView1.Columns[2].Visible = false;
        }

        public bool IsMdiChildrenInstance(string MdiChildrenName)
        { 
             foreach(Form childfrm in this.MdiParent.MdiChildren)
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
            if (!IsMdiChildrenInstance("XSXXGLZG"))
            {
                XSXXGLZG tj = new XSXXGLZG();
                tj.status = "添加";
                tj.MdiParent = this.MdiParent;
                dataup();
                tj.Show();
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (!IsMdiChildrenInstance("XSXXGLZG"))
            {
                XSXXGLZG tj = new XSXXGLZG();
                tj.status = "修改";
                tj.studentID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tj.MdiParent = this.MdiParent;
                dataup();
                tj.Show();
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认删除吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        int id = int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                        BLL.BLLStudentInfo.delete(id);
                    }
                    MessageBox.Show("删除成功！");
                    dataup();
                    return;
                }
                MessageBox.Show("删除失败！");
            }
        }

        private void button6_Click(object sender, System.EventArgs e)
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
                string bjid= textBox2.Text;
                string sql = "班级ID like '%" + bjid + "%'";
                DataSet ds = BLL.BLLStudentInfo.select(sql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            dataup();
        }
    }
        }
    

