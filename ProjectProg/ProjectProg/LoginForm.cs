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
    public partial class LoginForm : Form
    {
        //buat object dari class connect yang kita buat
        Connection con = new Connection();
        //buat object untuk memanggil method yang ada di mainform
        MainForm mf = new MainForm();
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Untuk keluar dari program
            Environment.Exit(1);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //memvalidasi jika textbox id / username kosong
            if (textBoxID.Text.Equals(""))
            {
                labelError.Text = "Please insert your Username";
            }
            //memvalidasi jika textbox Password kosong
            else if (textBoxPass.Text.Equals(""))
            {
                labelError.Text = "Please insert your Password";
            }
            //memvalidasi jika combobox role belum terpilih
            else if (comboBoxRole.SelectedIndex == -1)
	        {
                labelError.Text = "Please select your role";
	        }
            
            else
            {
                //untuk menampung data yang telah terkoneksi ke database
                DataTable dt = con.openDataTableQuery("select StaffID, Password, StaffPosition from MsStaff where StaffID ='"+textBoxID.Text+"' and Password = '"+textBoxPass.Text+"' and StaffPosition = '"+comboBoxRole.SelectedItem+"'");

                //memvalidasi jika ID, Password, Role salah
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Login failed!\nYou're not registered");
                }
                else
	            {
                    //Jika combobox terisi index 0 maka akan menjalankan 
                    //method adminstate yang ada di mainform
                    //dan labelwelcome akan terganti sesuai dengan role
                    if (comboBoxRole.SelectedIndex == 0)
	                {
                    mf.labelWelcome.Text = "Welcome, Admin";
                    mf.adminState();
	                }
                    //Jika combobox terisi index 1 maka akan menjalankan 
                    //method administratorState yang ada di mainform
                    //dan labelwelcome akan terganti sesuai dengan role
                    else if (comboBoxRole.SelectedIndex == 1)
                    {
                        mf.labelWelcome.Text = "Welcome, Administrator";
                        mf.administratorState();
                    }
                    //Jika combobox terisi index 2 maka akan menjalankan 
                    //method barberState yang ada di mainform
                    //dan labelwelcome akan terganti sesuai dengan role
                    else if (comboBoxRole.SelectedIndex == 2)
                    {
                        mf.labelWelcome.Text = "Welcome, Barber";
                        mf.barberState();
                    }
                    //Jika combobox terisi index 3 maka akan menjalankan 
                    //methodCashierState yang ada di mainform
                    //dan labelwelcome akan terganti sesuai dengan role
                    else if (comboBoxRole.SelectedIndex == 3)
                    {
                        mf.labelWelcome.Text = "Welcome, Cashier";
                        mf.cashierState();
                    }
                    //Jika combobox terisi index 4 maka akan menjalankan 
                    //method managerState yang ada di mainform
                    //dan labelwelcome akan terganti sesuai dengan role
                    else if (comboBoxRole.SelectedIndex == 4)
                    {
                        mf.labelWelcome.Text = "Welcome, Manager";
                        mf.managerState();
                    }
                    //Memunculkan Messagebox karena login berhasil
                    MessageBox.Show("Login Success");
                    //menampilkan main form
                    mf.Show();
                    //menghide (menutup form login)
                    Visible = false;
                    
	            }
                
            }

        }

        private void e(object sender, FormClosedEventArgs e)
        {
            //Untuk keluar dari program
            Environment.Exit(0);
        }

    }
}
