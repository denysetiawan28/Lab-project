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
    public partial class AddTransactionForm : Form
    {
        
        //buat object dari class connect yang kita buat
        Connection con = new Connection();
        //membuat list baru (vector)
        List<string> _add = new List<string>();

        String tampDate;
        int cek = -1;
        int index = 0;

        //method ini untuk mengenerate ID secara otomatis
        private void autoGenerate()
        {
            DataTable dt = con.openDataTableQuery("select TransactionID from HeaderTransaction");
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
                textBoxTrID.Text = "TR00" + pecah;
            }

            else if (pecah >= 10 || pecah <= 99)
            {
                textBoxTrID.Text = "TR0" + pecah;
            }

            else
            {
                textBoxTrID.Text = "TR" + pecah;
            }
        }

        public AddTransactionForm()
        {
            InitializeComponent();
            autoGenerate();
            listBoxCustTransaction.DataSource = _add;
        }

        //method ini digunakan untuk mengubah textbox, radio button, button,
        //data gridview, combobox ke kondisi normalnya / defaultnya
        private void normalState()
        {
            groupBoxTrDetail.Enabled = false;
            groupBoxTr.Enabled = true;
            groupBoxFindID.Enabled = true;

            cmbStaffID.SelectedIndex = -1;
            cmbCustID.SelectedIndex = -1;
            textBoxInputCustName.Clear();
            textBoxInputStaffName.Clear();

            listBoxCustID.DataSource = null;
            listBoxCustID.DisplayMember = null;

            listBoxStaffID.DataSource = null;
            listBoxStaffID.DisplayMember = null;

            listBoxServiceID.DataSource = null;
            listBoxServiceID.DisplayMember = null;
            textBoxServiceName.Clear();

            listBoxCustTransaction.DataSource = null;
            _add.Clear();
            listBoxCustTransaction.DataSource = _add;
            pictureBox1.ImageLocation = Application.StartupPath + "/img/Logo.png";

            
        }
        //method untuk membuka groupbox detail transaction
        //dan mendisable groupbox transaction, dan find id
        private void createState()
        {
            groupBoxTrDetail.Enabled = true;
            groupBoxTr.Enabled = false;
            groupBoxFindID.Enabled = false;
        }

       //untuk mensearch id customer
        private void textBoxInputCustName_KeyUp(object sender, KeyEventArgs e)
        {
            String tampSearch = textBoxInputCustName.Text;
            listBoxCustID.DataSource = con.openDataTableQuery("select CustomerID from MsCustomer where CustomerName like '%" + tampSearch + "%'");
            listBoxCustID.DisplayMember = "CustomerID";
        }

        //untuk mensearch id staff
        private void textBoxInputStaffName_KeyUp(object sender, KeyEventArgs e)
        {
            String tampSearch = textBoxInputStaffName.Text;
            listBoxStaffID.DataSource = con.openDataTableQuery("select StaffID from MsStaff where StaffName like '%" + tampSearch + "%'");
            listBoxStaffID.DisplayMember = "StaffID";
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            //untuk menampilkan data staff id ke combobox
            cmbStaffID.DataSource = con.openDataTableQuery("select StaffID from MsStaff");
            cmbStaffID.DisplayMember = "StaffID";

            //untuk menampilkan data customer id ke combobox
            cmbCustID.DataSource = con.openDataTableQuery("select CustomerID from MsCustomer");
            cmbCustID.DisplayMember = "CustomerID";
            //untuk menampilkan gambar awalan pada aplikasi
            pictureBox1.ImageLocation = Application.StartupPath + "/img/Logo.png";
        }

        //untuk mensearch service id
        private void textBoxServiceName_KeyUp(object sender, KeyEventArgs e)
        {
            String tampSearch = textBoxServiceName.Text;
            listBoxServiceID.DataSource = con.openDataTableQuery("select ServiceID from MsService where ServiceName like '%" + tampSearch + "%'");
            listBoxServiceID.DisplayMember = "ServiceID";
        }

        private void listBoxServiceID_Click(object sender, EventArgs e)
        {
            //menvalidasi listbox service id sudah dipilih atau belum
            if (listBoxServiceID.DataSource == null)
            {
                MessageBox.Show("Please input Service Name!", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (listBoxServiceID.DataSource != null)
            {
                DataTable dt = con.openDataTableQuery("select picture from MsService where ServiceID = '" + listBoxServiceID.Text + "'");
                pictureBox1.ImageLocation = Application.StartupPath + "/img/" + dt.Rows[0][0];
            }
        }

        private void buttonCreateTr_Click(object sender, EventArgs e)
        {
            if (cmbStaffID.SelectedIndex == -1) labelError.Text = "Staff ID must be chosen!";
            else if (cmbStaffID.SelectedIndex == -1) labelError.Text = "Customer ID must be chosen!";
            else
            {
                createState();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            normalState(); 
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            bool flag = true;
            
            //menvalidasi service id dalam listbox service id sudah di pilih
            if (listBoxServiceID.SelectedIndex == -1) 
            {
                MessageBox.Show("Please Choose Service ID","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                flag = false;
            }
            else
	        {
                flag =true;
	        }

            if (flag == true)
	        {
                bool baru = true;
                //mengecek apakah data berulang (duplicated) atau tidak
                for (int i = 0; i < _add.Count; i++)
                {
                    if (_add.ElementAt(i).Equals(listBoxServiceID.Text))
                    {
                        baru = false;
                    }
                }
                if (baru == false)
                {
                    MessageBox.Show("Cannot Choose the same service", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //memasukan service id yang di pilih ke dalam list yang telah terbuat
                    _add.Add(listBoxServiceID.Text);
                    listBoxCustTransaction.DataSource = null;
                    listBoxCustTransaction.DataSource = _add;
                    index++;
                }
	        }
        }

        private void buttonRemoveDetail_Click(object sender, EventArgs e)
        {
            //menvalidasi apakah data dalam listbox detail sudah terisi atau belum
            if (index == 0)
            {
                MessageBox.Show("Insert the Data first! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //menvalidasi apakah data dalam listbox detail sudah terpilih
            else if (cek == -1)
            {
                MessageBox.Show("Please Choose the data first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else
            {
                try
                {
                    //menremove pilihihan dari list
                    _add.RemoveAt(cek);
                    listBoxCustTransaction.DataSource = null;
                    listBoxCustTransaction.DataSource = _add;
                    index--;
                }
                catch (Exception)
                {
                    
                    
                }
            }
        }

        private void listBoxCustTransaction_Click(object sender, EventArgs e)
        {
            cek = listBoxCustTransaction.SelectedIndex;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            //menvalidasi apakah listbox detail ada isinya atau tidak
            if (index ==0)
            {
                MessageBox.Show("There must be at least 1 item", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tampDate = dateTimePicker2.Text;
                //memanggil fungsi connect (openreaderquery) untuk menginsert data dalam field2, combobox, checkbox
                //ke dalam database
                con.openReaderQuery("insert into HeaderTransaction values('"+textBoxTrID.Text+"','"+tampDate+"','"+cmbStaffID.Text+"','"+cmbCustID.Text+"')");

                for (int i = 0; i < _add.Count; i++)
                {
                    //memanggil fungsi connect (openreaderquery) untuk menginsert data dalam field2, combobox, checkbox
                    //ke dalam database
                    con.openDataTableQuery("insert into DetailTransaction values('" + textBoxTrID.Text + "','"+_add.ElementAt(i)+"')"); 
                }
                MessageBox.Show("Success add Transaction", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                normalState();
                this.Dispose();
            }
        }

        
    }
}
