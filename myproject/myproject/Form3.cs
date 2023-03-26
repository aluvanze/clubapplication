using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace myproject
{
    public partial class Form3 : Form
    {

        static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source= subzero.accdb");
        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "select* from users";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string user = reader.GetString(0);
                string pass = reader.GetValue(1).ToString();
                if(txtUser.Text==user & txtPass.Text == pass)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Close();
                }

            }

        }
    }
}
