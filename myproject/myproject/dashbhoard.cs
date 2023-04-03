using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace myproject
{
    public partial class dashbhoard : Form
    {
        public dashbhoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calender form = new calender();
            form.Show();
            this.Close();
        }
    }
}
