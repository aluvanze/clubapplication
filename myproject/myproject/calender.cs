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
    public partial class calender : Form
    {
        static OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data source= subzero.accdb");
        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;

        public calender()
        {
            InitializeComponent();
        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            string place = txtPlace.Text;
            string time = txtTime.Text;
            string lec = txtLec.Text;
            string day = txtDay.Text;
            con.Open();

            cmd.CommandText = "INSERT INTO events (place, [time], lec, [day]) VALUES (@place, @time, @lec, @day)";

            cmd.Parameters.AddWithValue("@place", place);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@lec", lec);
            cmd.Parameters.AddWithValue("@day", day);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Event added successfully!");

            // clear textboxes
            txtPlace.Clear();
            txtTime.Clear();
            txtLec.Clear();
            txtDay.Clear();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are on the Events Page!");

        }

        private void calender_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "SELECT * FROM events";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();

            string eventList = "";

            while (reader.Read())
            {
                string place = reader.GetString(0);
                string time = reader.GetString(1);
                string lec = reader.GetString(2);
                string day = reader.GetString(3);

                eventList += "place: " + place + " Time: " + time + " Day: " + day + "\n";
            }

            if (eventList != "")
            {
                lblEvents.Text = "Event list:\n" + eventList;
            }
            else
            {
                lblEvents.Text = "No users found";
            }

            con.Close();
            lblEvents.Font = new Font("Courier New", 10);
            lblEvents.AutoSize = false;
            lblEvents.Width = 400;
            lblEvents.Height = 300;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "SELECT * FROM events";
            cmd.Connection = con;
            reader = cmd.ExecuteReader();

            string eventList = "";

            while (reader.Read())
            {
                string place = reader.GetString(0);
                string time = reader.GetString(1);
                string lec = reader.GetString(2);
                string day = reader.GetString(3);

                eventList += "place: " + place + " Time: " + time + " Day: " + day + "\n";
            }

            if (eventList != "")
            {
                lblEvents.Text = "Event list:\n" + eventList;
            }
            else
            {
                lblEvents.Text = "No users found";
            }

            con.Close();
            lblEvents.Font = new Font("Courier New", 10);
            lblEvents.AutoSize = false;
            lblEvents.Width = 400;
            lblEvents.Height = 300;

        }

        private void registeredUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashbhoard form = new dashbhoard();
            form.Show();
            this.Close();

        }
    }
}
