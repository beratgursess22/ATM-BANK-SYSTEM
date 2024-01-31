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
    public partial class Recordnewcustomer : Form
    {
        public Recordnewcustomer()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FPTE8E0E\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
        private void btnsaved_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand order = new SqlCommand("insert into person (name,surname,tc,tel,acountno,passoword) values ( @p1,@p2,@p3,@p4,@p5,@p6)", connection);
            order.Parameters.AddWithValue("@p1", txtname.Text);
            order.Parameters.AddWithValue("@p2", txtsurname.Text);
            order.Parameters.AddWithValue("@p3", msktc.Text);
            order.Parameters.AddWithValue("@p4", msktel.Text);
            order.Parameters.AddWithValue("@p5", mskaccountno.Text);
            order.Parameters.AddWithValue("@p6", txtpassoword.Text);
            order.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("new person saved", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnrandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int number = r.Next(10000, 1000000);
            mskaccountno.Text = number.ToString();
        }
    }
}
