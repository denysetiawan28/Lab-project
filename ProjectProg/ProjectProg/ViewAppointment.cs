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
    public partial class ViewAppointment : Form
    {
        Connection con = new Connection();
        public ViewAppointment()
        {
            InitializeComponent();
        }
       
        private void ViewAppointment_Load(object sender, EventArgs e)
        {
            dataGridViewApp.DataSource = con.openDataTableQuery("select AppointmentID, Date, StartTime, EndTime, CustomerName,StaffName,Description from TrAppointment a, MsCustomer b, MsStaff c where a.CustomerID = b.CustomerID and a.StaffID = c.StaffID");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String tampSearch = "";
            if (comboBoxSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Search By must be Chosen!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearch.Text = "";
            }
            else
            {
                if (comboBoxSearch.SelectedIndex == 0)
                {
                    tampSearch = "AppointmentID";
                }
                else if (comboBoxSearch.SelectedIndex == 1)
                {
                    tampSearch = "Date";
                }
                else if (comboBoxSearch.SelectedIndex == 2)
                {
                    tampSearch = "StartTime";
                }
                else if (comboBoxSearch.SelectedIndex == 3)
                {
                    tampSearch = "EndTime";
                }
                else if (comboBoxSearch.SelectedIndex == 4)
                {
                    tampSearch = "CustomerName";
                }
                else
                {
                    tampSearch = "StaffName";
                }
                dataGridViewApp.DataSource = con.openDataTableQuery("select AppointmentID, Date, StartTime, EndTime, CustomerName,StaffName,Description from TrAppointment a, MsCustomer b, MsStaff c where  " + tampSearch + " like '%" + textBoxSearch.Text + "%' and a.CustomerID = b.CustomerID and a.StaffID = c.StaffID");
             }
        }
    }
}
