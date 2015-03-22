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
    public partial class MasterServiceForm : Form
    {
        //buat object dari class connect yang kita buat
        Connection con = new Connection();

        bool flag;
        int tanda = 0;

        //Method ini digunakan untuk mengecek akhiran dari textbox
        //dalam textbox picture
        public Boolean cekEnd(String a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a.EndsWith(".jpg") == true)
                {
                    return true;
                }
                else if (a.EndsWith(".gif") == true)
                {
                    return true; 
                }
                else if (a.EndsWith(".png") == true)
                {
                    return true;
                }
            }

            return false;
        }

        //method ini untuk mengenerate ID secara otomatis
        public void autoGenerate()
        {
            int panjangRow = dataGridViewService.RowCount;
            int pecah = 0;

            if (panjangRow == 0)
            {
                pecah = 1;
            }
            else
            {
                String ID = dataGridViewService.Rows[panjangRow - 1].Cells[0].Value.ToString();
                pecah = int.Parse(ID.Substring(2));
                pecah += 1;
            }

            if (pecah <= 9)
            {
                textBoxServiceID.Text = "SR00" + pecah;
            }
            else if (pecah >= 10 || pecah <=99)
            {
                textBoxServiceID.Text = "SR0" + pecah;
            }
            else
            {
                textBoxServiceID.Text = "SR" + pecah;
            }
        }

        //method ini dibuat agar table terrefresh saat di panggi
        public void refreshTable()
        {
            //ambil data dari database, dengan menggunakan fungsi dari class connect
            dataGridViewService.DataSource = con.openDataTableQuery("select * from MsService");
        }

        //method ini digunakan untuk menghapus data yang ada pada textbox 
        //atau radio button saat di panggil
        public void clearTextbox()
        {
            textBoxServiceID.Clear();
            textBoxServiceName.Clear();
            textBoxServicePrice.Clear();
            textBoxPicture.Clear();
        }

        //method ini digunakan untuk mengubah textbox, radio button, button,
        //data gridview, combobox ke kondisi normalnya / defaultnya
        public void normalState()
        {
            clearTextbox();

            dataGridViewService.Enabled = true;
            textBoxSearch.Enabled = true;
            comboBoxSearch.Enabled = true;

            textBoxServiceName.Enabled = false;
            textBoxServicePrice.Enabled = false;
            textBoxPicture.Enabled = false;

            buttonInsert.Enabled = true;
            buttonInsert.Visible = true;
            buttonUpdate.Enabled = true;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;

            buttonSave.Visible = false;
            buttonCancel.Visible = false;
            labelError.Text = "Label Error";
            pictureBox1.ImageLocation = Application.StartupPath + "/img/Logo.png";
        }

        //method ini digunakan untuk mengubah textbox, radio button, button,
        //data gridview, combobox ke kondisi insert
        public void insertState()
        {
            clearTextbox();

            dataGridViewService.Enabled = false;
            textBoxSearch.Enabled = false;
            comboBoxSearch.Enabled = false;

            textBoxServiceName.Enabled = true;
            textBoxServicePrice.Enabled = true;
            textBoxPicture.Enabled = true;

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
            dataGridViewService.Enabled = false;
            textBoxSearch.Enabled = false;
            comboBoxSearch.Enabled = false;

            
            textBoxServiceName.Enabled = true;
            textBoxServicePrice.Enabled = true;
            textBoxPicture.Enabled = true;
            
            buttonInsert.Visible = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Visible = false;

            buttonSave.Visible = true;
            buttonCancel.Visible = true;
        }

        public MasterServiceForm()
        {
            InitializeComponent();
            
        }

        private void MasterServiceForm_Load(object sender, EventArgs e)
        {
            //Memanggil method refresh table agar datagridview
            //yang berhubungan dengan database, terupdate terus
            refreshTable();
            //untuk menampilkan gambar awalan pada aplikasi
            pictureBox1.ImageLocation = Application.StartupPath + "/img/Logo.png";
            
        }

       

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            //memanggil method insert
            insertState(); 
            tanda = 1;
            //memanggil method autogenerate
            autoGenerate();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxServiceID.Text.Equals(""))
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            flag = false;
            int tampungPrice = 0;

            if (textBoxServiceName.Text.Equals("")) labelError.Text = "Name must be filled!";
            else if (textBoxServiceName.Text.Length < 3 || textBoxServiceName.Text.Length > 30) labelError.Text = "The length of name must between 3 and 30 characters";
            else if (textBoxServicePrice.Text.Equals("")) labelError.Text = "Price must be filled!";
            else if (textBoxServicePrice.Text.Length < 4 || textBoxServiceName.Text.Length > 10) labelError.Text = "Price must be 4-10 digits";
            else if (textBoxPicture.Text.Equals("")) labelError.Text = "Picture must be filled!";
            else if (cekEnd(textBoxPicture.Text) == false) labelError.Text = "Picture must be in '.jpg' or '.png' or '.gif' format!";
             else
	        {
                for (int i = 0; i < textBoxServicePrice.Text.Length; i++)
			    {
                    if (char.IsDigit(textBoxServicePrice.Text[i]))
                    {
                        flag = true;
                    }
			    }
                if (flag == false)
                {
                    labelError.Text = "Price only contain number";
                }
                else
                {
                    flag = true;
                    tampungPrice = int.Parse(textBoxServicePrice.Text);
                }
	        }
            if (tanda == 1 && flag == true)
            {
                //memanggil fungsi connect (openreaderquery) untuk menginsert data dalam field2, combobox, checkbox
                //ke dalam database
                con.openReaderQuery("insert into MsService values('"+textBoxServiceID.Text+"','"+textBoxServiceName.Text+"','"
                                    +textBoxServicePrice.Text+"','"+textBoxPicture.Text+"')");
                MessageBox.Show("Success to insert", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshTable();
                    tanda = 0;
                    normalState();
            }
            else if (tanda == 2 && flag == true)
            {
                //memanggil fungsi connect (openreaderquery) untuk mengupdate data dalam field2, combobox, checkbox
                //ke dalam database
                con.openReaderQuery("update MsService set ServiceName ='" + textBoxServiceName.Text + "', ServicePrice ='" + textBoxServicePrice.Text + "', Picture ='" 
                                    + textBoxPicture.Text + "' where ServiceID = '"+textBoxServiceID.Text+"'");
                MessageBox.Show("Success to update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshTable();
                    tanda = 0;
                    normalState();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearTextbox();
            normalState();
            labelError.Text = "Error Label";
        }

        //event ketika data gridview di klik, dan ditampilkan ke dalam textbox, radiobutton
        //(View table database)
        private void dataGridViewService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String tampungPic;
            if (dataGridViewService.RowCount > 0)
            {
                int row = dataGridViewService.CurrentRow.Index;
                tampungPic = dataGridViewService.Rows[row].Cells[3].Value.ToString();
                dataGridViewService.DataSource = con.openDataTableQuery("select * from MsService");
                
                textBoxServiceID.Text = dataGridViewService.Rows[row].Cells[0].Value.ToString();
                textBoxServiceName.Text = dataGridViewService.Rows[row].Cells[1].Value.ToString();
                textBoxServicePrice.Text = dataGridViewService.Rows[row].Cells[2].Value.ToString();
                textBoxPicture.Text = dataGridViewService.Rows[row].Cells[3].Value.ToString();
                pictureBox1.ImageLocation = Application.StartupPath + "/img/"+tampungPic+"";
                
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
                    tampSearch = "ServiceID";
                    labelError.Text = "Error Label";
                }
                else
                {
                    tampSearch = "ServiceName";
                    labelError.Text = "Error Label";
                }
                dataGridViewService.DataSource = con.openDataTableQuery("select * from MsService where " + tampSearch + " like '%" + textBoxSearch.Text + "%'");
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //mencek apakah data sudah terpilih atau belum
            if (textBoxServiceID.Text.Equals(""))
            {
                labelError.Text = "Please select data for delete";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    con.openReaderQuery("delete from MsService where ServiceID ='" + textBoxServiceID.Text + "'");
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
