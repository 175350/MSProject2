namespace UI
{
    partial class Mainform2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理系统ToolStripMenuItem,
            this.班级信息管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.学生信息管理ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1073, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理系统ToolStripMenuItem
            // 
            this.管理系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新登录ToolStripMenuItem});
            this.管理系统ToolStripMenuItem.Name = "管理系统ToolStripMenuItem";
            this.管理系统ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.管理系统ToolStripMenuItem.Text = "系统管理";
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.重新登录ToolStripMenuItem.Text = "重新登录";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // 班级信息管理ToolStripMenuItem
            // 
            this.班级信息管理ToolStripMenuItem.Name = "班级信息管理ToolStripMenuItem";
            this.班级信息管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.班级信息管理ToolStripMenuItem.Text = "班级信息管理";
            this.班级信息管理ToolStripMenuItem.Click += new System.EventHandler(this.班级信息管理ToolStripMenuItem_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            this.课程管理ToolStripMenuItem.Click += new System.EventHandler(this.课程管理ToolStripMenuItem_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            this.成绩管理ToolStripMenuItem.Click += new System.EventHandler(this.成绩管理ToolStripMenuItem_Click);
            // 
            // 学生信息管理ToolStripMenuItem1
            // 
            this.学生信息管理ToolStripMenuItem1.Name = "学生信息管理ToolStripMenuItem1";
            this.学生信息管理ToolStripMenuItem1.Size = new System.Drawing.Size(111, 24);
            this.学生信息管理ToolStripMenuItem1.Text = "学生信息管理";
            this.学生信息管理ToolStripMenuItem1.Click += new System.EventHandler(this.学生信息管理ToolStripMenuItem1_Click);
            // 
            // Mainform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 628);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mainform2";
            this.Text = "Mainform2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem1;
    }
}