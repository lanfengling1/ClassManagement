using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.label4.Visible = true;
                
            }
            else
            {
                this.label4.Visible = false;
            }
            if(this.textBox2.Text == "")
            {
                this.label5.Visible = true;
            }
            else
            {
                this.label5.Visible = false;
            }
            MessageBox.Show("成功输入");
            if (this.label4.Visible == false && this.label5.Visible==false)
            {
                MessageBox.Show("条件成立");
                if (this.comboBox1.Text == "班级管理")
                {
                    MessageBox.Show("跳转");
                    ClassForm classForm = new ClassForm();
                    classForm.Show();
                }
                else
                {
                    StuForm stuForm = new StuForm();
                    stuForm.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("执行ESC成功");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("班级管理");
            this.comboBox1.Items.Add("学生");
        }
    }
}
