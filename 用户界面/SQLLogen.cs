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
    public partial class SQLLogen : Form
    {
        public SQLLogen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DBUtinity.SQLHelp.ServerPort = textBox1.Text;
            DBUtinity.SQLHelp.LoginMethod = comboBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
