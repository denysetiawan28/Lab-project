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
    public partial class MasterCustomerForm : Form
    {
        //buat object dari class connect yang kita buat
        Connection con = new Connection();

        //Method ini digunakan untuk mengecek apakah ada huruf, simbol, whitespace
        //dalam textbox telp pada form master customer
        public Boolean cekTelp(String e)
        {
            for (int i = 0; i < e.Length; i++)
            {
                if (char.IsLetter(e[i]) == true)
                {
                    return false;
                }
                else if (char.IsSymbol(e[i]) == true)
                {
                    return false;
                }
                else if (char.IsWhiteSpace(e[i]) == true)
                {
                    return false;
                }
            }
            return true;
        }

        //Method ini digunakan untuk mengecek validasi email
        //apakah sudah ada simbol @ atau . (titik)
        //dan mengecek apakah di antara @ dan . sudah terisi atau belum
        public Boolean cekEmail(String c)
        {
            if (c.Contains('@') == false)
            {
                return false;
            }
            else if (c.Contains('.') == false)
            {
                return false;
            }
            else if (c.StartsWith("@") || c.StartsWith("."))
            {
                return false;
            }
            else if (c.EndsWith("@") || c.EndsWith("."))
            {
                return false;
            }
            else if (c.IndexOf("@") == c.IndexOf(".") + 1)
            {
                return false;
            }
            else if (c.IndexOf("@") == c.IndexOf(".") - 1)
            {
                return false;
            }
            else if (c.IndexOf("@") != c.LastIndexOf("@"))
            {
                return false;
            }
            else if (c.LastIndexOf(".") < c.IndexOf("@"))
            {
                return false;
            }
            else if (cekPointSeparated(c) == false)
            {
                return false;
            }
            return true;
        }

        //untuk mengecek apakah antara @ dan . (titik) sudah terisi
        //atau belum
        public Boolean cekPointSeparated(String email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '.')
                {
                    if (email[i - 1] == '.' || email[i + 1] == '.')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //method ini dibuat untuk mengecek nama, apakah ada angka atau pun simbol
        //pada textbox customer name
        public Boolean cekNama(String a)
        {
            for (int i = 0; i < a.Length ; i++)
            {
                if (char.IsDigit(a[i]) == true)
                {
                    return false;
                }
                else if (char.IsSymbol(a[i]) == true)
                {
                    return false;
                }
                else if (char.IsLetter(a[i]) == false)
                {
                    return false;
                }
            }
            return true;
            
        }

        //method ini untuk mengenerate ID secara otomatis
        public void autoGenerate()
        {
            int panjangRow = dataGridViewMsCustomer.RowCount;
            int pecah = 0;

            if (panjangRow == 0)
            {
                pecah = 1;
            }
            else
            {
                string ID = dataGridViewMsCustomer.Rows[panjangRow - 1].Cells[0].Value.ToString();
                pecah = int.Parse(ID.Substring(2));
                pecah += 1;
            }
            if (pecah <= 9)
            {
                textBoxCustID.Text = "CU00" + pecah;
            }
            else if (pecah >= 10 || pecah <= 99)
            {
                textBoxCustID.Text = "CU0" + pecah;
            }
            else
            {
                textBoxCustID.Text = "CU" + pecah;
            }
        }
        //method ini dibuat agar table terrefresh saat di panggil
        public void refreshTable()
        {
            //ambil data dari database, dengan menggunakan fungsi dari class connect
            dataGridViewMsCustomer.DataSource = con.openDataTableQuery("select * from MsCustomer");
        }

        //method ini digunakan untuk menghapus data yang ada pada textbox 
        //atau radio button saat di panggil
        public void clearTextbox()
        {
            textBoxCustID.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            textBoxCustName.Clear();
            textBoxCustEmail.Clear();
            textBoxCustPhone.Clear();
            textBoxCustAddress.Clear();
        }

        //method ini digunakan untuk mengubah textbox, radio button, button,
        //data gridview, combobox ke kondisi normalnya / defaultnya
        public void normalState()
        {
            clearTextbox();

            dataGridViewMsCustomer.Enabled = true;
            textBoxSearch.Enabled = true;
            comboBoxSearch.Enabled = true;

            radioButtonMale.Enabled = false;
            radioButtonFemale.Enabled = false;
            textBoxCustName.Enabled = false;
            textBoxCustEmail.Enabled = false;
            textBoxCustPhone.Enabled = false;
            textBoxCustAddress.Enabled = false;

            buttonInsert.Enabled = true;
            buttonInsert.Visible = true;
            buttonUpdate.Enabled = true;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;

            buttonSave.Visible = false;
            buttonCancel.Visible = false;
            labelError.Text = "Label Error";
        }

        //method ini digunakan untuk mengubah textbox, radio button, button,
        //data gridview, combobox ke kondisi insert
        public void insertState()
        {
            clearTextbox();

            dataGridViewMsCustomer.Enabled = false;
            textBoxSearch.Enabled = false;
            comboBoxSearch.Enabled = false;

            radioButtonMale.Enabled = true;
            radioButtonFemale.Enabled = true;
            textBoxCustName.Enabled = true;
            textBoxCustEmail.Enabled = true;
            textBoxCustPhone.Enabled = true;
            textBoxCustAddress.Enabled = true;

            buttonInsert.Enabled = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;

            buttonSave.Visible = true;
            buttonCancel.Visible = true;
        }

        //method ini digunakan untuk mengubah textbox, radio button, button,
        //data gridview, combobox ke kondisi update
        public void updateState()
        {
            dataGridViewMsCustomer.Enabled = false;
            textBoxSearch.Enabled = false;
            comboBoxSearch.Enabled = false;

            radioButtonMale.Enabled = true;
            radioButtonFemale.Enabled = true;
            textBoxCustName.Enabled = true;
            textBoxCustEmail.Enabled = true;
            textBoxCustPhone.Enabled = true;
            textBoxCustAddress.Enabled = true;

            buttonInsert.Visible = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Visible = false;

            buttonSave.Visible = true;
            buttonCancel.Visible = true;
        }

        int tanda = 0;
        String TempGender;
        String tampGender;
        

        public MasterCustomerForm()
        {
            InitializeComponent();
        }

        private void MasterCustomerForm_Load(object sender, EventArgs e)
        {
            //Memanggil method refresh table agar datagridview
            //yang berhubungan dengan database, terupdate terus
            refreshTable();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            //memanggil method insert
            insertState();
            //mengubah tanda dari 0 jadi 1
            tanda = 1;
            //memanggil method autogenerate
            autoGenerate();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //memanggil method clear
            clearTextbox();
            //memanggil method normalstate / default
            normalState();
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Boolean flag;
            long tampTelp = 0;
            String tampPhone = "";
            
            /*Untuk menvalidasi apakah radio button sudah terpilih, textbox tidak kosong,
             * panjang textbox sesuai dengan kriteria
             */
            if (radioButtonFemale.Checked == false && radioButtonMale.Checked == false) labelError.Text = "Gender Must Be Chosen!";
            else if (textBoxCustName.Text.Equals("")) labelError.Text = "Name Must Be Filled!";
            else if (textBoxCustName.Text.Length < 3 || textBoxCustName.Text.Length > 30)labelError.Text = "The length of name must between 3 and 30 characters";
            else if (cekNama(textBoxCustName.Text) == false) labelError.Text = "Name only contain alphabet";
            else if (textBoxCustEmail.Text.Equals("")) labelError.Text = "Email Must Be Filled!";
            else if (cekEmail(textBoxCustEmail.Text) == false) labelError.Text = "Wrong email format";
            else if (textBoxCustAddress.Text.Equals(""))labelError.Text = "Address Must Be Filled!";
            else if (!textBoxCustAddress.Text.EndsWith("Street"))labelError.Text = "Address must end with 'Street'";   
            else if (textBoxCustPhone.Text.Equals(""))labelError.Text = "Phone must be filled!";
            else if (cekTelp(textBoxCustPhone.Text) == false)labelError.Text = "Phone only contains number";
            else if (textBoxCustPhone.Text.Length < 6 || textBoxCustPhone.Text.Length > 20)labelError.Text = "Phone must be 6-20 digits";
            
            else
            {
                flag = true;
                //menampung telp dalam bentuk string
                tampPhone = textBoxCustPhone.Text.ToString();
                //menparse bentuk string ke int
                tampTelp = Int64.Parse(tampPhone);
                
                //menampung radio button dalam bentuk string
                if (radioButtonFemale.Checked) TempGender = "Female";
                else if (radioButtonMale.Checked) TempGender = "Male";

                if (flag == true & tanda == 1)
                {
                    //memanggil fungsi connect (openreaderquery) untuk menginsert data dalam field2, checkbox
                    //ke dalam database
                    con.openReaderQuery("insert into MsCustomer values('"+textBoxCustID.Text+"','"
                                        +TempGender+"','"+textBoxCustName.Text+"','"+textBoxCustEmail.Text+"','"
                                        +textBoxCustAddress.Text+"','"+tampTelp+"')");
                    MessageBox.Show("Success to insert", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TempGender = "";
                    refreshTable();
                    tanda = 0;
                    normalState();
                }
                else if (flag == true && tanda == 2)
                {
                    //memanggil fungsi connect (openreaderquery) untuk mengupdate data dalam field2, combobox, checkbox
                    //ke dalam database
                    con.openReaderQuery("update MsCustomer set CustomerGender ='"+TempGender+"', CustomerName ='"
                                        +textBoxCustName.Text+"', CustomerEmail ='"+textBoxCustEmail.Text+"', CustomerAddress ='"
                                        +textBoxCustAddress.Text+"',CustomerPhone = '"+tampTelp+"' where CustomerID = '"+textBoxCustID.Text+"'");
                    MessageBox.Show("Success to update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TempGender = "";
                    refreshTable();
                    tanda = 0;
                    normalState();
                }
              }
        }

        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCustID.Text.Equals(""))
            {
                labelError.Text = "Choose data First!";
            }
            else
            {
                updateState();
                tanda = 2;
                labelError.Text = "Error Label";
            }
            
        }

        //event ketika data gridview di klik, dan ditampilkan ke dalam textbox, radiobutton
        //(View table database)
        private void dataGridViewMsCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMsCustomer.RowCount > 0)
            {
                int row = dataGridViewMsCustomer.CurrentRow.Index;
                dataGridViewMsCustomer.DataSource = con.openDataTableQuery("select * from MsCustomer");
                tampGender = dataGridViewMsCustomer.Rows[row].Cells[1].Value.ToString();
            
                textBoxCustID.Text = dataGridViewMsCustomer.Rows[row].Cells[0].Value.ToString();
            
                if (tampGender == "Male") radioButtonMale.Checked = true;
                else if (tampGender == "Female") radioButtonFemale.Checked = true;
            
                textBoxCustName.Text = dataGridViewMsCustomer.Rows[row].Cells[2].Value.ToString();
                textBoxCustEmail.Text = dataGridViewMsCustomer.Rows[row].Cells[3].Value.ToString();
                textBoxCustAddress.Text = dataGridViewMsCustomer.Rows[row].Cells[4].Value.ToString();
                textBoxCustPhone.Text = dataGridViewMsCustomer.Rows[row].Cells[5].Value.ToString();
            }
        }

        //event key up untuk mencari ke dalam database sesuai yang di cari
        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            String tampSearch = "";
            if (comboBoxSearch.SelectedIndex == -1)
            {
                labelError.Text = "Search By must be Chosen!";
                textBoxSearch.Text = "";
            }
            else
            {
                if (comboBoxSearch.SelectedIndex == 0)
                {
                    tampSearch = "CustomerID";
                    labelError.Text = "Error Label";
                }
                else
                {
                    tampSearch = "CustomerName";
                    labelError.Text = "Error Label";
                }
                dataGridViewMsCustomer.DataSource = con.openDataTableQuery("select * from MsCustomer where " + tampSearch + " like '%" + textBoxSearch.Text + "%'");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (textBoxCustID.Text.Equals(""))
            {
                labelError.Text = "Please select data for delete";
                textBoxSearch.Text = "";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    con.openReaderQuery("delete from MsCustomer where CustomerID ='" + textBoxCustID.Text + "'");
                    refreshTable();
                    clearTextbox();
                }
                else if (result.Equals(DialogResult.No))
                {
                    normalState();
                }
            }
        }

       
    }
}
