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
    public partial class Form1 : Form
    {

        static OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data source= subzero.accdb");
        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "SELECT * FROM members";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();

            string userList = "";

            while (reader.Read())
            {
                string user = reader.GetString(0);
                string course = reader.GetString(2);
                string lyear = reader.GetString(3);

                userList += "Username: " + user + " Course: " + course + " Last Year: " + lyear + "\n";
            }

            if (userList != "")
            {
                lblUsers.Text = "User list:\n" + userList;
            }
            else
            {
                lblUsers.Text = "No users found";
            }

            con.Close();
            lblUsers.Font = new Font("Courier New", 10);
            lblUsers.AutoSize = false;
            lblUsers.Width = 400;
            lblUsers.Height = 300;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            string course = txtCourse.Text;
            string lyear = txtYear.Text;

            con.Open();

            cmd.CommandText = "INSERT INTO members (username, [password], course, lyear) VALUES (@username, @password, @course, @lyear)";

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@lyear", lyear);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("User added successfully!");

            // clear textboxes
            txtUser.Clear();
            txtPass.Clear();
            txtCourse.Clear();
            txtYear.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd.CommandText = "SELECT * FROM members";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();

            string userList = "";

            while (reader.Read())
            {
                string user = reader.GetString(0);
                string course = reader.GetString(2);
                string lyear = reader.GetString(3);

                userList += "Username: " + user + " Course: " + course + " Last Year: " + lyear + "\n";
            }

            if (userList != "")
            {
                lblUsers.Text = "User list:\n" + userList;
            }
            else
            {
                lblUsers.Text = "No users found";
            }

            con.Close();

        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calender form = new calender();
            form.Show();
            this.Close();

        }

        private void registeredUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are on the User's Page!");

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashbhoard form = new dashbhoard();
            form.Show();
            this.Close();

        }
    }
}
