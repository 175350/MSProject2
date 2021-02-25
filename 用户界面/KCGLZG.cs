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
    public partial class KCGLZG : Form
    {
        public KCGLZG()
        {
            InitializeComponent();
        }

        public string status;
        public string classID;
        Model.KCInfo kc = new Model.KCInfo();
        KCGL kcgl= new KCGL();
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "添加")
            {
                kc.课程ID = textBox1.Text;
                kc.课程名称 = textBox2.Text;
                kc.班级ID = textBox3.Text;
                kc.考试类型 = textBox4.Text;
                if (BLL.BLLKCInfo.add(kc))
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
                kc.课程名称 = textBox2.Text;
                kc.课程ID = textBox1.Text;
                kc.考试类型 = textBox4.Text;
                if (BLL.BLLKCInfo.modify(kc, classID))
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
            KCGL.kc.dataup();
        }

        private void KCGLZG_Load(object sender, EventArgs e)
        {
            if (status == "添加")
            {
                button1.Text = "添加";
            }
            else
            {
                button1.Text = "修改";
                string strwhere = "班级ID='" + classID + "'";
                DataSet ds = BLL.BLLKCInfo.select(strwhere);
                textBox1.Text = ds.Tables[0].Rows[0]["课程ID"].ToString();
                textBox2.Text = ds.Tables[0].Rows[0]["课程名称"].ToString();
                textBox3.Text = ds.Tables[0].Rows[0]["班级ID"].ToString();
                textBox4.Text = ds.Tables[0].Rows[0]["考试类型"].ToString();
            }
        }

    }
}
