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
    public partial class XSXXGLZG : Form
    {
        public string status;
        public string studentID;
        public XSXXGLZG()
        {
            InitializeComponent();
        }
        Model.StudentInfo stu = new Model.StudentInfo();
        XSXX xsxx = new XSXX();
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "添加")
            {
                stu.XH = textBox1.Text;
                stu.XM = textBox2.Text;
                stu.MM = textBox3.Text;
                stu.BJID = textBox4.Text;
                if (BLL.BLLStudentInfo.add(stu))
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                stu.XM = textBox2.Text;
                stu.MM = textBox3.Text;
                stu.BJID = textBox4.Text;
                if (BLL.BLLStudentInfo.modify(stu, studentID))
                {
                    MessageBox.Show("修改数据成功");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("修改数据失败");
                }
            }
            XSXX.xsxx.dataup();
        }

        private void XSXXGLZG_Load(object sender, EventArgs e)
        {
            if (status == "添加")
            {
                button1.Text = "添加";
            }
            else
            {
                button1.Text = "修改";
                string strwhere = "学号='" + studentID + "'";
                DataSet ds = BLL.BLLStudentInfo.select(strwhere);
                textBox1.Text = ds.Tables[0].Rows[0]["学号"].ToString();
                textBox2.Text = ds.Tables[0].Rows[0]["姓名"].ToString();
                textBox3.Text = ds.Tables[0].Rows[0]["密码"].ToString();
                textBox4.Text = ds.Tables[0].Rows[0]["班级ID"].ToString();
            }
        }
    }
}
