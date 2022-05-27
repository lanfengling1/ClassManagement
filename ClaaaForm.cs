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
    public partial class ClaaaForm : Form
    {
        public ClaaaForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                this.label3.Visible = true;
            }
            else
            {
                this.label3.Visible = false;
            }
            if (this.textBox2.Text == "")
            {
                this.label4.Visible = true;
            }
            else
            {
                this.label4.Visible = false;
            }
        }
    }
}
