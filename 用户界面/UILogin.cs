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
    public partial class UILogin : Form
    {
        public UILogin()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string yh= textBox1.Text;
            string mm= textBox2.Text;
            string sf= comboBox1.Text;
            string sqlstr = "用户名='" + yh + "' and 密码='" + mm + "' and 身份='" + sf + "'";
            DataSet da = BLL.BLLAdministrator.select(sqlstr);


            if (comboBox1.Text == "超级管理员")
            {
                if (da.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("登录成功！");
                    this.DialogResult = DialogResult.OK;
                    Mainform mf = new Mainform();
                    mf.Parent = this.Parent;
                    mf.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }

            else if (comboBox1.Text == "普通管理员")
            {
                if (da.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("登录成功！");
                    this.DialogResult = DialogResult.OK;
                    Mainform2 mf = new Mainform2();
                    mf.Parent = this.Parent;
                    mf.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
            else
                {
                    if (da.Tables[0].Rows.Count > 0)
                    {
                    MessageBox.Show("登录成功！");
                    this.DialogResult = DialogResult.OK;
                    Mainform1 mf1 = new Mainform1();
                    mf1.Parent = this.Parent;
                    mf1.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    }
                      else
                {
                    MessageBox.Show("登录失败！");
                }
                }

            }

        private void UILogin_Load(object sender, EventArgs e)
        {

        }
        }
    }
