using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ListPlayer
{
    public partial class Form1 : Form
    {

        string strConnect = @"Data Source=LAPTOP-G8QQS8BJ\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";

        SqlConnection sqlConnect = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if(sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if(sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from listPlayer";

            sqlCmd.Connection = sqlConnect;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string Name = reader.GetString(1);
                int Matches = reader.GetInt32(2);

                ListViewItem listPlayer = new ListViewItem(ID.ToString());
                listPlayer.SubItems.Add(Name);
                listPlayer.SubItems.Add(Matches.ToString());

                listData.Items.Add(listPlayer);
            }

            reader.Close();
        }
    }
}
