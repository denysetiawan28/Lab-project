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
    public partial class ViewTransactionForm : Form
    {
        Connection con = new Connection();
        public ViewTransactionForm()
        {
            InitializeComponent();
        }

        private void ViewTransactionForm_Load(object sender, EventArgs e)
        {
            dataGridViewTr.DataSource = con.openDataTableQuery("select a.TransactionID, TransactionDate,StaffID,CustomerID,ServiceName from HeaderTransaction a, DetailTransaction b, MsService c where  a.TransactionID = b.TransactionID and b.ServiceID = c.ServiceID");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            String tampSearch = "";
            String tampDetail = "";
            if (comboBoxSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Search By must be Chosen!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearch.Text = "";
            }
            else
            {
                if (comboBoxSearch.SelectedIndex == 0)
                {
                    tampSearch = "TransactionID";
                    tampDetail = "a";
                }
                else if (comboBoxSearch.SelectedIndex == 1)
                {
                    tampSearch = "TransactionDate";
                    tampDetail = "a";
                }
                else if (comboBoxSearch.SelectedIndex == 2)
                {
                    tampSearch = "StaffID";
                    tampDetail = "a";
                }
                else if (comboBoxSearch.SelectedIndex == 3)
                {
                    tampSearch = "CustomerID";
                    tampDetail = "a";
                }
                else
                {
                    tampSearch = "ServiceName";
                    tampDetail = "c";
                }
                dataGridViewTr.DataSource = con.openDataTableQuery("select a.TransactionID, TransactionDate, StaffID, CustomerID, ServiceName from HeaderTransaction a, DetailTransaction b, MsService c where  "+tampDetail+"." + tampSearch + " like '%" + textBoxSearch.Text + "%' and a.TransactionID = b.TransactionID and b.ServiceID = c.ServiceID");
                //dataGridViewTr.DataSource = con.openDataTableQuery("SELECT A.TransactionID , A.TransactionDate, A.StaffID, A.CustomerID, C.ServiceName FROM HeaderTransaction A,DetailTransaction B,MsService C WHERE B.ServiceID=C.ServiceID and "+tampDetail+"."+tampSearch+" like '%"+textBoxSearch.Text+"%'");
            }
        }
    }
}
