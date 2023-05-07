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

namespace FindOpponent
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

        private void button1_Click(object sender, EventArgs e) // no paramater
        {
            if(sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if(sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            string hoten = txtName.Text.Trim();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from PlayerDB where Name = 'DinhDat'"; // select * from PlayerDB where Name = 'DinhDat'

            sqlCmd.Connection = sqlConnect;

            //thuc thi
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if(reader.Read())
            {
                string namePlayer = reader.GetString(1);
                int winMatch = reader.GetInt32(2);
                int loseMatch = reader.GetInt32(3);
                int drawMatch = reader.GetInt32(4);

                // hien thi giao dien

                txtName.Text = namePlayer;
                txtWinMatch.Text = winMatch.ToString();
                txtLoseMatch.Text = loseMatch.ToString();
                txtDrawMatch.Text = drawMatch.ToString();
            }

            // Dong dau doc
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            string hoten = txtName.Text.Trim();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from PlayerDB where Name= 'VanTung'"; // select * from PlayerDB where Name = 'DinhDat'

            //Dinh nghia
            SqlParameter paraName = new SqlParameter("@Name", SqlDbType.NVarChar);
            paraName.Value = txtName.Text.Trim();
            sqlCmd.Parameters.Add(paraName);

            sqlCmd.Connection = sqlConnect;
            //thuc thi
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                string namePlayer = reader.GetString(1);
                int winMatch = reader.GetInt32(2);
                int loseMatch = reader.GetInt32(3);
                int drawMatch = reader.GetInt32(4);

                // hien thi giao dien

                txtName.Text = namePlayer;
                txtWinMatch.Text = winMatch.ToString();
                txtLoseMatch.Text = loseMatch.ToString();
                txtDrawMatch.Text = drawMatch.ToString();
            }

            // Dong dau doc
            reader.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbLoseMatch_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
