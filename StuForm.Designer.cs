
namespace WindowsFormsApp1
{
    partial class StuForm
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
            this.基本信息IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册情况rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程安排AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.家庭成员信息FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖惩信息RPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.奖励信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.惩罚信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息IToolStripMenuItem,
            this.注册情况rToolStripMenuItem,
            this.课程安排AToolStripMenuItem,
            this.家庭成员信息FToolStripMenuItem,
            this.奖惩信息RPToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 基本信息IToolStripMenuItem
            // 
            this.基本信息IToolStripMenuItem.Name = "基本信息IToolStripMenuItem";
            this.基本信息IToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.基本信息IToolStripMenuItem.Text = "基本信息(&I)";
            this.基本信息IToolStripMenuItem.Click += new System.EventHandler(this.基本信息IToolStripMenuItem_Click);
            // 
            // 注册情况rToolStripMenuItem
            // 
            this.注册情况rToolStripMenuItem.Name = "注册情况rToolStripMenuItem";
            this.注册情况rToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.注册情况rToolStripMenuItem.Text = "注册情况(&R)";
            // 
            // 课程安排AToolStripMenuItem
            // 
            this.课程安排AToolStripMenuItem.Name = "课程安排AToolStripMenuItem";
            this.课程安排AToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.课程安排AToolStripMenuItem.Text = "课程安排(&A)";
            // 
            // 家庭成员信息FToolStripMenuItem
            // 
            this.家庭成员信息FToolStripMenuItem.Name = "家庭成员信息FToolStripMenuItem";
            this.家庭成员信息FToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.家庭成员信息FToolStripMenuItem.Text = "家庭成员信息(&F)";
            // 
            // 奖惩信息RPToolStripMenuItem
            // 
            this.奖惩信息RPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.奖励信息ToolStripMenuItem,
            this.惩罚信息ToolStripMenuItem});
            this.奖惩信息RPToolStripMenuItem.Name = "奖惩信息RPToolStripMenuItem";
            this.奖惩信息RPToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.奖惩信息RPToolStripMenuItem.Text = "奖惩信息(&N)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 21);
            // 
            // 奖励信息ToolStripMenuItem
            // 
            this.奖励信息ToolStripMenuItem.Name = "奖励信息ToolStripMenuItem";
            this.奖励信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.奖励信息ToolStripMenuItem.Text = "奖励信息";
            // 
            // 惩罚信息ToolStripMenuItem
            // 
            this.惩罚信息ToolStripMenuItem.Name = "惩罚信息ToolStripMenuItem";
            this.惩罚信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.惩罚信息ToolStripMenuItem.Text = "惩罚信息";
            // 
            // StuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StuForm";
            this.Text = "学生";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本信息IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册情况rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程安排AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 家庭成员信息FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖惩信息RPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 奖励信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 惩罚信息ToolStripMenuItem;
    }
}