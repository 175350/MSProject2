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
    public partial class XSGRXXCJ : Form
    {
        public static XSGRXXCJ grcj;
        public XSGRXXCJ()
        {
            InitializeComponent();
            grcj = this;
        }

        public void dataup()
        {

            DataSet da = BLL.BLLStudentCJ.select("");
            dataGridView1.DataSource = da.Tables[0];

        }
        private void XSGRXXCJ_Load(object sender, EventArgs e)
        {
            dataup();
            dataGridView1.Columns[2].Visible = false;
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
    }
}
