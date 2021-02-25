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
    public partial class CJBLZG : Form
    {
        public CJBLZG()
        {
            InitializeComponent();
        }

        public string status;
        public string studentID;
        Model.CJInfo cj = new Model.CJInfo();
        CJGL1 cjgl = new CJGL1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "添加")
            {
                cj.学号 = textBox1.Text;
                cj.课程ID = textBox2.Text;
                cj.成绩 = textBox3.Text;
                cj.课程名称 = textBox4.Text;
                if (BLL.BLLCJInfo.add(cj))
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
                cj.课程ID = textBox2.Text;
                cj.成绩 = textBox3.Text;
                cj.课程名称 = textBox4.Text;
                if (BLL.BLLCJInfo.modify(cj, studentID))
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
            CJGL1.cjgl.dataup();
        }

        private void CJBLZG_Load(object sender, EventArgs e)
        {
            if (status == "添加")
            {
                button1.Text = "添加";
            }
            else
            {
                button1.Text = "修改";
                string strwhere = "学号='" + studentID + "'";
                DataSet ds = BLL.BLLCJInfo.select(strwhere);
                textBox1.Text = ds.Tables[0].Rows[0]["学号"].ToString();
                textBox2.Text = ds.Tables[0].Rows[0]["课程ID"].ToString();
                textBox3.Text = ds.Tables[0].Rows[0]["成绩"].ToString();
                textBox4.Text = ds.Tables[0].Rows[0]["课程名称"].ToString();
            }
        }
    }
}
