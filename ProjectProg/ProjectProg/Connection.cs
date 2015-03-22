using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectProg
{
    class Connection
    {
        
        private SqlConnection con;
        private string constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Database1.mdf;Integrated Security=True;User Instance=True";
        private SqlDataAdapter adapter;
        private SqlDataReader reader;
        private SqlCommand cmd;
        private DataTable dt;

        public void connect()
        {
            con = new SqlConnection(constr);
            if (con.State == ConnectionState.Closed)
            {
                con.Close();
            }
        }

        public void openReaderQuery(string query)
        {
            try
            {
                connect();
                if (con.State == ConnectionState.Closed)
                {
                    con.Close();
                }
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database ERROR!!!" + e.Message, "Message");
                throw;
            }
            con.Close();
        }

        public DataTable openDataTableQuery(string query)
        {
            try
            {
                connect();
                if (con.State == ConnectionState.Closed)
                {
                    con.Close();
                }
                con.Open();
                dt = new DataTable();
                dt.Clear();
                adapter = new SqlDataAdapter(query, constr);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Database ERROR!!!" + e.Message, "Message");
            }
            con.Close();
            return dt;
        }
    }
}
