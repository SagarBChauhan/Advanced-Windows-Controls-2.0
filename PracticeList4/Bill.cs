using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticeList4
{
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from tblRestaurant;", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void BtnRestaurant_Click(object sender, EventArgs e)
        {
            restaurant rs = new restaurant();
            rs.Show();
            this.Hide();

        }
    }
}
