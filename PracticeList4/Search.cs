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
    public partial class Search : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            da = new SqlDataAdapter("Select * from tblJob_master;",con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CbSearch.SelectedIndex==0)
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Close();
                da = new SqlDataAdapter("Select * from tblJob_master where vehicle_no Like '"+TxtSearch.Text+"';", con);
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if(CbSearch.SelectedIndex==1)
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Close();
                da = new SqlDataAdapter("Select * from tblJob_master  where  job_description like '"+TxtSearch.Text+"';", con);
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (CbSearch.SelectedIndex == 2)
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Close();
                da = new SqlDataAdapter("Select * from tblJob_master where  typeofjob like '" + TxtSearch.Text + "';", con);
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

    }
}
