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
    public partial class MasterStaffForm : Form
    {
        //buat object dari class connect yang kita buat
        Connection con = new Connection();

        //Method ini digunakan untuk mengecek apakah ada huruf, simbol, whitespace
        //dalam textbox telp pada form master staff
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
            for (int i = 0; i < a.Length; i++)
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

        //method ini digunakan untuk menghapus data yang ada pada textbox 
        //atau radio button saat di panggil
        public void clearTextbox()
        {
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;

            textBoxStaffID.Clear();
            textBoxStaffPassword.Clear();
            textBoxStaffName.Clear();
            textBoxStaffEmail.Clear();
            textBoxStaffAddress.Clear();
            textBoxStaffPhone.Clear();
            comboBoxStaffPosition.SelectedIndex = -1;
        }

        //method ini digunakan untuk mengubah textbox, radio button, button,
        //data gridview, combobox ke kondisi normalnya / defaultnya
        public void normalState()
        {
            clearTextbox();

            dataGridViewMsStaff.Enabled = true;
            textBoxSearch.Enabled = true;
            comboBoxSearch.Enabled = true;

            textBoxStaffPassword.Enabled = false;
            radioButtonMale.Enabled = false;
            radioButtonFemale.Enabled = false;
            textBoxStaffName.Enabled = false;
            textBoxStaffEmail.Enabled = false;
            textBoxStaffAddress.Enabled = false;
            textBoxStaffPhone.Enabled = false;
            comboBoxStaffPosition.Enabled = false;

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

            dataGridViewMsStaff.Enabled = false;
            textBoxSearch.Enabled = false;
            comboBoxSearch.Enabled = false;

            textBoxStaffPassword.Enabled = true;
            radioButtonMale.Enabled = true;
            radioButtonFemale.Enabled = true;
            textBoxStaffName.Enabled = true;
            textBoxStaffEmail.Enabled = true;
            textBoxStaffAddress.Enabled = true;
            textBoxStaffPhone.Enabled = true;
            comboBoxStaffPosition.Enabled = true;

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
            dataGridViewMsStaff.Enabled = false;
            textBoxSearch.Enabled = false;
            comboBoxSearch.Enabled = false;

            textBoxStaffPassword.Enabled = true;
            radioButtonMale.Enabled = true;
            radioButtonFemale.Enabled = true;
            textBoxStaffName.Enabled = true;
            textBoxStaffEmail.Enabled = true;
            textBoxStaffAddress.Enabled = true;
            textBoxStaffPhone.Enabled = true;
            comboBoxStaffPosition.Enabled = true;

            buttonInsert.Visible = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Visible = false;

            buttonSave.Visible = true;
            buttonCancel.Visible = true;
        }

        //method ini untuk mengenerate ID secara otomatis
        public void autoGenerate()
        {
            int panjangRow = dataGridViewMsStaff.RowCount;
            int pecah = 0;

            if (panjangRow == 0)
            {
                pecah = 1;
            }
            else
            {
                string ID = dataGridViewMsStaff.Rows[panjangRow - 1].Cells[0].Value.ToString();
                pecah = int.Parse(ID.Substring(2));
                pecah += 1;
            }
            if (pecah <=9)
            {
                textBoxStaffID.Text = "ST00" + pecah;
            }
            else if (pecah >= 10 || pecah <= 99)
            {
                textBoxStaffID.Text = "ST0" + pecah;
            }
            else
            {
                textBoxStaffID.Text = "ST" + pecah;
            }
        }

        //method ini dibuat agar table terrefresh saat di panggil
        public void refreshTable()
        {
            //ambil data dari database, dengan menggunakan fungsi dari class connect
            dataGridViewMsStaff.DataSource = con.openDataTableQuery("select * from MsStaff");
        }

        String TampGender;
        String TampPosition;
        String TempGender;
        int tanda = 0;

        public MasterStaffForm()
        {
            InitializeComponent();
        }

        private void MasterStaffForm_Load(object sender, EventArgs e)
        {
            //Memanggil method refresh table agar datagridview
            //yang berhubungan dengan database, terupdate terus
            refreshTable();
        }

       
        private void button1_Click(object sender, EventArgs e) //Insert Button
        {
            //memanggil method insert
            insertState();
            tanda = 1;
            //memanggil method autogenerate
            autoGenerate();
        }

     
        private void button2_Click(object sender, EventArgs e) //Update Button
        {
            //mencek apakah data sudah terpilih atau belum
            if (textBoxStaffID.Text.Equals(""))
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

        private void button3_Click(object sender, EventArgs e) //Delete Button
        {
            //mencek apakah data sudah terpilih atau belum
            if (textBoxStaffID.Text.Equals(""))
            {
                labelError.Text = "Please select data for delete";
            }
            else
            {
                //menampung hasil result (yes / no) message box
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                //mencek result
                if (result.Equals(DialogResult.Yes))
                {
                    con.openReaderQuery("delete from MsStaff where StaffID ='"+textBoxStaffID.Text+"'");
                    refreshTable();
                    clearTextbox();
                }
                else if (result.Equals(DialogResult.No))
                {
                    normalState();
                }
            }

        }

        private void button5_Click(object sender, EventArgs e) //Cancel Button
        {
            //memanggil method normal / default
            normalState();
            tanda = 0;
        }

        private void button4_Click(object sender, EventArgs e) //Save Button
        {
            Boolean flag;
            
            long tampTelp = 0;

                /*Untuk menvalidasi apakah radio button sudah terpilih, textbox tidak kosong,
                 * panjang textbox sesuai dengan kriteria
                 */
                if (textBoxStaffPassword.Text.Equals("")) labelError.Text = "Password must be filled!";
                else if (textBoxStaffPassword.Text.Length < 6 || textBoxStaffPassword.Text.Length > 40) labelError.Text = "The length of password must be between 8 and 40 characters";
                else if (radioButtonFemale.Checked == false && radioButtonMale.Checked == false) labelError.Text = "Gender Must Be Chosen!";
                else if (textBoxStaffName.Text.Equals("")) labelError.Text = "Name Must Be Filled!";
                else if (textBoxStaffName.Text.Length < 3 || textBoxStaffName.Text.Length > 30) labelError.Text = "The length of name must between 3 and 30 characters";
                else if (cekNama(textBoxStaffName.Text) == false) labelError.Text = "Name only contain alphabet";
                else if (textBoxStaffEmail.Text.Equals("")) labelError.Text = "Email Must Be Filled!";
                else if (cekEmail(textBoxStaffEmail.Text) == false) labelError.Text = "Wrong email format";
                else if (textBoxStaffAddress.Text.Equals("")) labelError.Text = "Address Must Be Filled!";
                else if (!textBoxStaffAddress.Text.EndsWith("Street")) labelError.Text = "Address must end with 'Street'";
                else if (textBoxStaffPhone.Text.Equals("")) labelError.Text = "Phone must be filled!";
                else if (cekTelp(textBoxStaffPhone.Text) == false) labelError.Text = "Phone only contains number";
                else if (textBoxStaffPhone.Text.Length < 6 || textBoxStaffPhone.Text.Length > 20) labelError.Text = "Phone must be 6-20 digits";
                else if (comboBoxStaffPosition.SelectedIndex == -1) labelError.Text = "Staff position must be chosen!";
                else
                {
                    flag = true;
                    //menparse bentuk string ke int
                    tampTelp = Int64.Parse(textBoxStaffPhone.Text);

                    //menampung radio button dalam bentuk string
                    if (radioButtonFemale.Checked) TempGender = "Female";
                    else if (radioButtonMale.Checked) TempGender = "Male";
                    
                        
                    if (tanda == 1 && flag == true)
                    {
                        //memanggil fungsi connect (openreaderquery) untuk menginsert data dalam field2, combobox, checkbox
                        //ke dalam database
                        con.openReaderQuery("insert into MsStaff values ('" + textBoxStaffID.Text + "','"
                                         + textBoxStaffPassword.Text + "','" + TempGender + "','"
                                         + textBoxStaffName.Text + "','" + textBoxStaffEmail.Text + "','"
                                         + textBoxStaffAddress.Text + "','" + tampTelp + "','" + comboBoxStaffPosition.SelectedItem + "')");
                        MessageBox.Show("Success to insert","Insert",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TempGender = "";
                        refreshTable();
                        tanda = 0;
                        normalState();
                    }
                    else if (tanda == 2 && flag == true)
                    {
                        //memanggil fungsi connect (openreaderquery) untuk mengupdate data dalam field2, combobox, checkbox
                        //ke dalam database
                        con.openReaderQuery("update MsStaff set Password = '"+textBoxStaffPassword.Text+"',StaffGender ='"+TempGender+"', StaffName ='"
                                            +textBoxStaffName.Text+"', StaffEmail ='"+textBoxStaffEmail.Text+"',StaffAddress ='"
                                            +textBoxStaffAddress.Text+"',StaffPhone = '"+tampTelp+"',StaffPosition = '"+comboBoxStaffPosition.SelectedItem+"' where StaffID = '"+textBoxStaffID.Text+"'");
                        MessageBox.Show("Success to update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TempGender = "";
                        refreshTable();
                        tanda = 0;
                        normalState();
                    }
                } 
               
        }


        //event ketika data gridview di klik, dan ditampilkan ke dalam textbox, radiobutton
        //(View table database)
        private void dataGridViewMsStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMsStaff.RowCount > 0)
            {
                int row = dataGridViewMsStaff.CurrentRow.Index;
                TampGender = dataGridViewMsStaff.Rows[row].Cells[2].Value.ToString();
                TampPosition = dataGridViewMsStaff.Rows[row].Cells[7].Value.ToString();

                textBoxStaffID.Text = dataGridViewMsStaff.Rows[row].Cells[0].Value.ToString();
                textBoxStaffPassword.Text = dataGridViewMsStaff.Rows[row].Cells[1].Value.ToString();

                if (TampGender == "Male")radioButtonMale.Checked = true;
                else if (TampGender == "Female") radioButtonFemale.Checked = true;

                textBoxStaffName.Text = dataGridViewMsStaff.Rows[row].Cells[3].Value.ToString();
                textBoxStaffEmail.Text = dataGridViewMsStaff.Rows[row].Cells[4].Value.ToString();
                textBoxStaffAddress.Text = dataGridViewMsStaff.Rows[row].Cells[5].Value.ToString();
                textBoxStaffPhone.Text = dataGridViewMsStaff.Rows[row].Cells[6].Value.ToString();

                if (TampPosition == "Admin")comboBoxStaffPosition.SelectedIndex = 0;
                else if (TampPosition == "Administrator")comboBoxStaffPosition.SelectedIndex = 1;
                else if (TampPosition == "Barber")comboBoxStaffPosition.SelectedIndex = 2;
                else if (TampPosition == "Cashier")comboBoxStaffPosition.SelectedIndex = 3;
                else if (TampPosition == "Manager") comboBoxStaffPosition.SelectedIndex = 4;
                
            }
            
        }

        //event key up untuk mencari ke dalam database sesuai yang di cari
        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            String tampSearch = "";
            //mencek apakah combobox search by sudah terpilih atau belum
            if (comboBoxSearch.SelectedIndex == -1)
            {
                labelError.Text = "Search By must be Chosen!";
                textBoxSearch.Text = "";
            }
            else
            {
                if (comboBoxSearch.SelectedIndex == 0)
                {
                    tampSearch = "StaffID";
                    labelError.Text = "Error Label";
                }
                else
                {
                    tampSearch = "StaffName";
                    labelError.Text = "Error Label";
                }
                dataGridViewMsStaff.DataSource = con.openDataTableQuery("select * from MsStaff where " + tampSearch + " like '%" + textBoxSearch.Text + "%'");
            }
        }
        }
    }

