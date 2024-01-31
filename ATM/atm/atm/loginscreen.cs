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
    public partial class loginscreen : Form
    {
        public loginscreen()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FPTE8E0E\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand order = new SqlCommand("select * from person where acountno=@p1 and passoword=@p2", connection);
            order.Parameters.AddWithValue("@p1", mskaccountno.Text);
            order.Parameters.AddWithValue("@p2", txtpassoword.Text);
            SqlDataReader dr = order.ExecuteReader();
            if (dr.Read())
            {
                Account fr = new Account();
                fr.account = mskaccountno.Text;
                fr.Show();

            }
            else
            {
                MessageBox.Show("Wrong Account No Or Passoword");
            }
            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recordnewcustomer fr = new Recordnewcustomer();
            fr.Show();
        }
    }
}
