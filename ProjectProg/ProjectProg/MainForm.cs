using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProjectProg
{
    public partial class MainForm : Form
    {
        MasterCustomerForm mCust;
        MasterServiceForm mServ;
        MasterStaffForm mStaf;
        AddAppointmentForm aApp;
        AddTransactionForm aTra;
        ViewAppointment vApp;
        ViewTransactionForm vTra;

        //method untuk menclose semua form
        public void CloseAllForm()
        {
            try
            {
                mCust.Dispose();
                mServ.Dispose();
                mStaf.Dispose();
                aApp.Dispose();
                aTra.Dispose();
                vApp.Dispose();
                vTra.Dispose();
            }
            catch (Exception)
            {

            }
        }

        //method yang dibuat agar terlihat sesuai dengan role
        public void adminState()
        {
            logoutToolStripMenuItem.Visible = true;
            exitToolStripMenuItem.Visible = true;

            masterToolStripMenuItem.Visible = true;
            masterCustomerToolStripMenuItem.Visible = true;
            masterServiceToolStripMenuItem.Visible = true;
            masterStaffToolStripMenuItem.Visible = true;

            appointmentToolStripMenuItem.Visible = true;
            addAppointmentToolStripMenuItem.Visible = true;
            viewAppointmentToolStripMenuItem.Visible = true;

            transactionToolStripMenuItem.Visible = true;
            addTransactionToolStripMenuItem.Visible = true;
            viewTransactionToolStripMenuItem.Visible = true;
        }

        //method yang dibuat agar terlihat sesuai dengan role
        public void administratorState()
        {
            logoutToolStripMenuItem.Visible = true;
            exitToolStripMenuItem.Visible = true;

            masterToolStripMenuItem.Visible = false;
            masterCustomerToolStripMenuItem.Visible = false;
            masterServiceToolStripMenuItem.Visible = false;
            masterStaffToolStripMenuItem.Visible = false;

            appointmentToolStripMenuItem.Visible = true;
            addAppointmentToolStripMenuItem.Visible = true;
            viewAppointmentToolStripMenuItem.Visible = true;

            transactionToolStripMenuItem.Visible = false;
            addTransactionToolStripMenuItem.Visible = false;
            viewTransactionToolStripMenuItem.Visible = false;
        }

        //method yang dibuat agar terlihat sesuai dengan role
        public void barberState()
        {
            logoutToolStripMenuItem.Visible = true;
            exitToolStripMenuItem.Visible = true;

            masterToolStripMenuItem.Visible = false;
            masterCustomerToolStripMenuItem.Visible = false;
            masterServiceToolStripMenuItem.Visible = false;
            masterStaffToolStripMenuItem.Visible = false;

            appointmentToolStripMenuItem.Visible = true;
            addAppointmentToolStripMenuItem.Visible = false;
            viewAppointmentToolStripMenuItem.Visible = true;

            transactionToolStripMenuItem.Visible = false;
            addTransactionToolStripMenuItem.Visible = false;
            viewTransactionToolStripMenuItem.Visible = false;
        }

        //method yang dibuat agar terlihat sesuai dengan role
        public void cashierState()
        {
            logoutToolStripMenuItem.Visible = true;
            exitToolStripMenuItem.Visible = true;

            masterToolStripMenuItem.Visible = false;
            masterCustomerToolStripMenuItem.Visible = false;
            masterServiceToolStripMenuItem.Visible = false;
            masterStaffToolStripMenuItem.Visible = false;

            appointmentToolStripMenuItem.Visible = false;
            addAppointmentToolStripMenuItem.Visible = false;
            viewAppointmentToolStripMenuItem.Visible = false;

            transactionToolStripMenuItem.Visible = true;
            addTransactionToolStripMenuItem.Visible = true;
            viewTransactionToolStripMenuItem.Visible = true;
        }

        //method yang dibuat agar terlihat sesuai dengan role
        public void managerState()
        {
            logoutToolStripMenuItem.Visible = true;
            exitToolStripMenuItem.Visible = true;

            masterToolStripMenuItem.Visible = true;
            masterCustomerToolStripMenuItem.Visible = true;
            masterServiceToolStripMenuItem.Visible = true;
            masterStaffToolStripMenuItem.Visible = true;

            appointmentToolStripMenuItem.Visible = true;
            addAppointmentToolStripMenuItem.Visible = false;
            viewAppointmentToolStripMenuItem.Visible = true;

            transactionToolStripMenuItem.Visible = true;
            addTransactionToolStripMenuItem.Visible = false;
            viewTransactionToolStripMenuItem.Visible = true;
        }
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            //Membuat object baru dari login form
            LoginForm lf = new LoginForm();
            labelWelcome.Text = "Welcome, ";
            //membuat login form jadi visible / terlihat / muncul
            lf.Visible = true;
            //membuat mainform menjadi tertutup / tak terlihat
            Visible = false;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void masterCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menshow menu master
            if (mCust == null || mCust.IsDisposed)
            {
                mCust = new MasterCustomerForm();
                mCust.MdiParent = this;
                mCust.Show();
            }
           
        }

        private void masterStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //menshow menu master
            if (mStaf == null || mStaf.IsDisposed)
            {
                mStaf = new MasterStaffForm();
                mStaf.MdiParent = this;
                mStaf.Show();
            }
        }

        private void masterServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menshow menu master
            if (mServ == null || mServ.IsDisposed)
            {
                mServ = new MasterServiceForm();
                mServ.MdiParent = this;
                mServ.Show();
            }
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menshow add appointment
            if (aApp == null || aApp.IsDisposed)
            {
                aApp = new AddAppointmentForm();
                aApp.MdiParent = this;
                aApp.Show();
            }
        }

        private void viewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menshow view appointment
            if (vApp == null || vApp.IsDisposed)
            {
                vApp = new ViewAppointment();
                vApp.MdiParent = this;
                vApp.Show();
            }
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menshow add transaction
            if (aTra == null || aTra.IsDisposed)
            {
                aTra = new AddTransactionForm();
                aTra.MdiParent = this;
                aTra.Show();
            }
        }

        private void viewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menshow view transaction
            if (vTra == null || vTra.IsDisposed)
            {
                vTra = new ViewTransactionForm();
                vTra.MdiParent = this;
                vTra.Show();
            }
        }

    }
}
