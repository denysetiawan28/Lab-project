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
    public partial class AddAppointmentForm : Form
    {
        //Method untuk mengembalikan semua componen menjadi default / kembali
        //ke posisi normal
        public void normalState()
        {
            ScmbFirstHour.SelectedIndex = -1;
            ScmbSecondHour.SelectedIndex = -1;
            ScmbFirstMinute.SelectedIndex = -1;
            ScmbSecondMinute.SelectedIndex = -1;

            EcmbFirstHour.SelectedIndex = -1;
            EcmbSecondHour.SelectedIndex = -1;
            EcmbFirstMinute.SelectedIndex = -1;
            EcmbSecondMinute.SelectedIndex = -1;
            
            cmbCustID.SelectedIndex -= 1;
            cmbStaffID.SelectedIndex -= 1;
            textBoxDescription.Text = "";
        }

        String tampStartTime;
        String tampEndTime;
        String tampCust;
        String tampStaff;
        String tampDate;
        //buat object dari class connect yang kita buat
        Connection con = new Connection();

        //method ini untuk mengenerate ID secara otomatis
        public void autoGenerate()
        {
            DataTable dt = con.openDataTableQuery("select AppointmentID from TrAppointment");
            string id = dt.Rows[dt.Rows.Count - 1][0].ToString();

            int panjangRow = dt.Rows.Count;
            int pecah = 0;

            if (panjangRow == 0)
            {
                pecah = 1;
            }
            else
            {
                pecah = int.Parse(id.Substring(2));
                pecah += 1;
            }

            if (pecah <= 9)
            {
                textBoxAppointmentID.Text = "AP00" + pecah;
            }
            else if (pecah >= 10 || pecah <= 99)
            {
                textBoxAppointmentID.Text = "AP0" + pecah;
            }
            else
            {
                textBoxAppointmentID.Text = "AP" + pecah;
            }
        }

        public AddAppointmentForm()
        {
            InitializeComponent();
            autoGenerate();
        }

        
        
        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            //untuk menampilkan data customer id ke combobox
            cmbCustID.DataSource = con.openDataTableQuery("select CustomerID from MsCustomer");
            cmbCustID.DisplayMember = "CustomerID";

            //untuk menampilkan data staff id ke combobox
            cmbStaffID.DataSource = con.openDataTableQuery("select StaffID from MsStaff where StaffPosition = 'Barber'");
            cmbStaffID.DisplayMember = "StaffID";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            /*menvalidasi apakah semua componen (textbox, combobox) sudah terpilih / terisi
             */ 
            if (ScmbFirstHour.SelectedIndex == -1) labelError.Text = "First hour digit in start time must be chosen";
            else if (ScmbSecondHour.SelectedIndex == -1) labelError.Text = "Second hour digit in start time must be chosen";
            else if (ScmbFirstMinute.SelectedIndex == -1) labelError.Text = "First minute digit in start time must be chosen";
            else if (ScmbSecondMinute.SelectedIndex == -1) labelError.Text = "Second minute digit in start time must be chosen";


            else if (EcmbFirstHour.SelectedIndex == -1) labelError.Text = "First hour digit in end time must be chosen";
            else if (EcmbSecondHour.SelectedIndex == -1) labelError.Text = "Second hour digit in End time must be chosen";
            else if (EcmbFirstMinute.SelectedIndex == -1) labelError.Text = "First minute digit in end time must be chosen";
            else if (EcmbSecondMinute.SelectedIndex == -1) labelError.Text = "Second minute digit in end time must be chosen";

            else if (cmbCustID.SelectedIndex == -1) labelError.Text = "Customer ID must be chosen!";
            else if (cmbStaffID.SelectedIndex == -1) labelError.Text = "Staff ID must be chosen!";
            else if (textBoxDescription.Text.Equals("")) labelError.Text = "Description must be filled!";
            else if (textBoxDescription.Text.Length > 100) labelError.Text = "Description lenght must less than 100 character!";


            else
            {
                tampDate = dateTimeAppointment.Text;
                tampStartTime = ScmbFirstHour.SelectedItem + "" + ScmbSecondHour.SelectedItem + ":" + ScmbFirstMinute.SelectedItem + "" + ScmbSecondMinute.SelectedItem + " WIB";
                tampEndTime = EcmbFirstHour.SelectedItem + "" + EcmbSecondHour.SelectedItem + ":" + EcmbFirstMinute.SelectedItem + "" + EcmbSecondMinute.SelectedItem + " WIB";
                tampCust = cmbCustID.Text;
                tampStaff = cmbStaffID.Text;

                //memanggil fungsi connect (openreaderquery) untuk menginsert data dalam field2, combobox, checkbox
                //ke dalam database
                con.openReaderQuery("insert into TrAppointment values('" + textBoxAppointmentID.Text + "','"
                                        +tampDate+"','"+tampStartTime+"','"+tampEndTime+"','"+tampCust+"','"
                                        +tampStaff+"','"+textBoxDescription.Text+"')");
                MessageBox.Show("Success add Appointment", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                normalState();
                autoGenerate();
            }
        }
     }
}

