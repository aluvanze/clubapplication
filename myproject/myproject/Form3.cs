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

        static OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data source= subzero.accdb");
        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {



            con.Open();
            cmd.CommandText = "SELECT * FROM users";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();
            string userList = "";

            bool foundUser = false;

            while (reader.Read())
            {
                string user = reader.GetString(0);
                string pass = reader.GetString(1);
                userList += "Username: " + user + ", Password: " + pass + "\n";

                if (txtUser.Text == user && txtPass.Text == pass)
                {
                    foundUser = true;
                    break;
                }
            }

            if (foundUser)
            {
                dashbhoard form = new dashbhoard();
                form.Show();
                this.Close();
            }
            else
            {
                lblerror.Text = "Invalid login details";
               
                lblerror.ForeColor = Color.Red;
            }

            con.Close();


        }
    }
}
