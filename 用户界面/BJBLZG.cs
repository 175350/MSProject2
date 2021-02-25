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
    public partial class BJBLZG : Form
    {
        public BJBLZG()
        {
            InitializeComponent();
        }
        public string status;
        public string classID;
        Model.ClassInfo bj= new Model.ClassInfo();
        BJGL bjgl = new BJGL();
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "添加")
            {
                bj.班级ID= textBox1.Text;
                bj.班级名称= textBox2.Text;
                if (BLL.BLLClassInfo.add(bj))
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
                bj.班级ID = textBox1.Text;
                bj.班级名称 = textBox2.Text;
                if (BLL.BLLClassInfo.modify(bj, classID))
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
            BJGL.bjgl.dataup();
        }

        private void BJBLZG_Load(object sender, EventArgs e)
        {
            if (status == "添加")
            {
                button1.Text = "添加";
            }
            else
            {
                button1.Text = "修改";
                string strwhere = "班级ID='" + classID + "'";
                DataSet ds = BLL.BLLClassInfo.select(strwhere);
                textBox1.Text = ds.Tables[0].Rows[0]["班级ID"].ToString();
                textBox2.Text = ds.Tables[0].Rows[0]["班级名称"].ToString();
            }
        }
    }
}
