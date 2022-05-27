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
    public partial class StuForm : Form
    {
        public StuForm()
        {
            InitializeComponent();
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
