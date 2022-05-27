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
            ClaaaForm claaaForm = new ClaaaForm();
            claaaForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StuForm stuForm = new StuForm();
            stuForm.Show();
        }
    }
}
