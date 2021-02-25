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
    public partial class XGMM : Form
    {
        public XGMM()
        {
            InitializeComponent();
        }

        Model.Administrator xg = new Model.Administrator();
        private void button1_Click(object sender, EventArgs e)
        {
            
           this.xg.密码 = textBox1.Text;
           this.xg.身份 = textBox2.Text;
           this.xg.用户名 = textBox3.Text;
            if (BLL.BLLAdministrator.modify(xg))
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
        
       
    }
}
