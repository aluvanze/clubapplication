
namespace myproject
{
    partial class calender
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtLec = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblLec = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.btnEAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registeredUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 266);
            this.label1.TabIndex = 1;
            // 
            // lblEvents
            // 
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(12, 40);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(388, 36);
            this.lblEvents.TabIndex = 2;
            this.lblEvents.Text = "EVENTS";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(582, 65);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(139, 20);
            this.txtPlace.TabIndex = 3;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(582, 102);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(139, 20);
            this.txtTime.TabIndex = 4;
            // 
            // txtLec
            // 
            this.txtLec.Location = new System.Drawing.Point(582, 151);
            this.txtLec.Name = "txtLec";
            this.txtLec.Size = new System.Drawing.Size(139, 20);
            this.txtLec.TabIndex = 5;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(582, 193);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(139, 20);
            this.txtDay.TabIndex = 6;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(521, 72);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(34, 13);
            this.lblPlace.TabIndex = 7;
            this.lblPlace.Text = "Place";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(521, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // lblLec
            // 
            this.lblLec.AutoSize = true;
            this.lblLec.Location = new System.Drawing.Point(521, 158);
            this.lblLec.Name = "lblLec";
            this.lblLec.Size = new System.Drawing.Size(46, 13);
            this.lblLec.TabIndex = 9;
            this.lblLec.Text = "Lecturer";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(517, 196);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(26, 13);
            this.lblday.TabIndex = 10;
            this.lblday.Text = "Day";
            // 
            // btnEAdd
            // 
            this.btnEAdd.Location = new System.Drawing.Point(613, 251);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEAdd.TabIndex = 11;
            this.btnEAdd.Text = "Add Event";
            this.btnEAdd.UseVisualStyleBackColor = true;
            this.btnEAdd.Click += new System.EventHandler(this.btnEAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.calenderToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // calenderToolStripMenuItem
            // 
            this.calenderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem});
            this.calenderToolStripMenuItem.Name = "calenderToolStripMenuItem";
            this.calenderToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.calenderToolStripMenuItem.Text = "Calender";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registeredUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // registeredUsersToolStripMenuItem
            // 
            this.registeredUsersToolStripMenuItem.Name = "registeredUsersToolStripMenuItem";
            this.registeredUsersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registeredUsersToolStripMenuItem.Text = "Registered Users";
            this.registeredUsersToolStripMenuItem.Click += new System.EventHandler(this.registeredUsersToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(46, 376);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(170, 50);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEAdd);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lblLec);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtLec);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "calender";
            this.Text = "calender";
            this.Load += new System.EventHandler(this.calender_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtLec;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLec;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Button btnEAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registeredUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}