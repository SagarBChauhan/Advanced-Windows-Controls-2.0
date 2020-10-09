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
    public partial class restaurant : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public restaurant()
        {
            InitializeComponent();
        }

        private void restaurant_Load(object sender, EventArgs e)
        {
            TxtNo.Enabled = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                SqlDataReader dr;
                cmd = new SqlCommand("Select * from tblRestaurant where ItemNo=" + TxtNo.Text + ";", con);
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    TxtNAme.Text = dr.GetValue(1).ToString();
                    TxtPrice.Text = dr.GetValue(2).ToString();
                    TxtQty.Text = dr.GetValue(3).ToString();

                }
                else
                {
                    MessageBox.Show("NO RECODE FOUND");
                    ClearData();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Value Inserted to Find");
            }
        }

        private void ClearData()
        {
            TxtNAme.Text = "";
            TxtPrice.Text="";
            TxtQty.Text = "";
           // throw new NotImplementedException();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {   try
            {
            con.Close();
            cmd = new SqlCommand("insert into tblRestaurant (ItemName,ItemPrice,ItemQty)values ('"+TxtNAme.Text+"',"+TxtPrice.Text+","+TxtQty.Text+"); ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Value Inserted ");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                cmd = new SqlCommand("update  tblRestaurant set ItemName='" + TxtNAme.Text + "',ItemPrice=" + TxtPrice.Text + ",ItemQty=" + TxtQty.Text + "; ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated");
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Value Inserted to Update");
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            TxtNo.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                cmd = new SqlCommand("delete from tblRestaurant where ItemNo=" + TxtNo.Text + "; ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated");
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No Value Inserted to Delete");
            }
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            Bill bi = new Bill();
            bi.Show();
            this.Hide();
        }
    }
}
