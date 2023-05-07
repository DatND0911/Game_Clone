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

namespace ConnectDB
{
    public partial class Form1 : Form
    {
        // create 2 local variale
        string strConnect = @"Data Source=LAPTOP-G8QQS8BJ\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";

        // Object connect
        SqlConnection sqlConnect = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                if(sqlConnect == null) // rong thi tao moi
                {
                    sqlConnect = new SqlConnection(strConnect);
                }

                // connect succces
                if (sqlConnect.State == ConnectionState.Closed) // dong thi mo
                {
                    sqlConnect.Open();
                    MessageBox.Show("Connect successed!!!");
                }
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConnect != null && sqlConnect.State == ConnectionState.Open)
            {
                sqlConnect.Close();
                MessageBox.Show("Disconnect successed!!!");
            }
            else
            {
                MessageBox.Show("Don't create Connection!!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Access_Data_Click(object sender, EventArgs e)
        {
            if(sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            // doi tuong thuc thi truy van

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select COUNT (*) from PlayerDB";

            // gui truy van vao ket noi
            sqlCmd.Connection = sqlConnect;

            // nhan ket qua
            int countPlayer = (int)sqlCmd.ExecuteScalar();
            
            MessageBox.Show("So luong nguoi choi: " + countPlayer);
        }
    }
}
