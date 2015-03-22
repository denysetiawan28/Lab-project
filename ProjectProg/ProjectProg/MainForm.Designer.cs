namespace ProjectProg
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterCustomerToolStripMenuItem,
            this.masterStaffToolStripMenuItem,
            this.masterServiceToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            
            // 
            // masterCustomerToolStripMenuItem
            // 
            this.masterCustomerToolStripMenuItem.Name = "masterCustomerToolStripMenuItem";
            this.masterCustomerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.masterCustomerToolStripMenuItem.Text = "Master Customer";
            this.masterCustomerToolStripMenuItem.Click += new System.EventHandler(this.masterCustomerToolStripMenuItem_Click);
            // 
            // masterStaffToolStripMenuItem
            // 
            this.masterStaffToolStripMenuItem.Name = "masterStaffToolStripMenuItem";
            this.masterStaffToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.masterStaffToolStripMenuItem.Text = "Master Staff";
            this.masterStaffToolStripMenuItem.Click += new System.EventHandler(this.masterStaffToolStripMenuItem_Click);
            // 
            // masterServiceToolStripMenuItem
            // 
            this.masterServiceToolStripMenuItem.Name = "masterServiceToolStripMenuItem";
            this.masterServiceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.masterServiceToolStripMenuItem.Text = "Master Service";
            this.masterServiceToolStripMenuItem.Click += new System.EventHandler(this.masterServiceToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointmentToolStripMenuItem,
            this.viewAppointmentToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // addAppointmentToolStripMenuItem
            // 
            this.addAppointmentToolStripMenuItem.Name = "addAppointmentToolStripMenuItem";
            this.addAppointmentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addAppointmentToolStripMenuItem.Text = "Add Appointment";
            this.addAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentToolStripMenuItem_Click);
            // 
            // viewAppointmentToolStripMenuItem
            // 
            this.viewAppointmentToolStripMenuItem.Name = "viewAppointmentToolStripMenuItem";
            this.viewAppointmentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.viewAppointmentToolStripMenuItem.Text = "View Appointment";
            this.viewAppointmentToolStripMenuItem.Click += new System.EventHandler(this.viewAppointmentToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.viewTransactionToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addTransactionToolStripMenuItem.Text = "Add Transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // viewTransactionToolStripMenuItem
            // 
            this.viewTransactionToolStripMenuItem.Name = "viewTransactionToolStripMenuItem";
            this.viewTransactionToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.viewTransactionToolStripMenuItem.Text = "View Transaction";
            this.viewTransactionToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionToolStripMenuItem_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(12, 34);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(150, 31);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome, ";
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 323);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionToolStripMenuItem;
        public System.Windows.Forms.Label labelWelcome;
    }
}