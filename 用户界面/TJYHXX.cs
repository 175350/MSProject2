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
    public partial class TJYHXX : Form
    {
        public TJYHXX()
        {
            InitializeComponent();
        }
        Model.Administrator yh= new Model.Administrator();
        private void button1_Click(object sender, EventArgs e)
        {
                yh.用户名 = textBox1.Text;
                yh.密码 = textBox2.Text;
                yh.身份 = comboBox1.Text;
                if (BLL.BLLAdministrator.add(yh))
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("失败");
                }
             

            }
        }
    }

