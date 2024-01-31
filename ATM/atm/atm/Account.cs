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

namespace atm
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        public string account;
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FPTE8E0E\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            lblaccountno.Text = account;

            connection.Open();
            SqlCommand order = new SqlCommand("select * from person where acountno=@p1", connection);
            order.Parameters.AddWithValue("@p1", account);
            SqlDataReader dr = order.ExecuteReader();
            while (dr.Read())
            {
                lblnamesurname.Text = dr[1] + " " + dr[2];
                lblaccountno.Text = dr[5].ToString();
                lbltel.Text = dr[4].ToString();
                lbltc.Text = dr[3].ToString();
            }
            connection.Close();
        }

        private void lbltc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand order = new SqlCommand("update Balance set balance=balance+@p1 where acountno=@p2", connection);
            order.Parameters.AddWithValue("@p1", decimal.Parse (txtamount.Text));
            order.Parameters.AddWithValue("@p2", mskaccountno.Text);
            order.ExecuteNonQuery();
            connection.Close();


            connection.Open();
            SqlCommand order2 = new SqlCommand("update Balance set balance= balanace-@k1 where acountno=@k2", connection);
            order.Parameters.AddWithValue("@k1", decimal.Parse(txtamount.Text));
            order.Parameters.AddWithValue("@k2", account);
            order.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Process finish");
        }
    }
}
