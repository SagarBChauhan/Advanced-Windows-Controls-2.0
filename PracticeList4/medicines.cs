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
    public partial class medicines : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public medicines()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                cmd = new SqlCommand("insert into tblMedicine (Name,ExpiryDate,Qty,ReorderLevel,SellPrice) values('" + TxtName.Text + "','" + dateTimePicker1.Value + "'," + TxtQty.Text + "," + TxtReorderleval.Text + "," + TxtSellPrice.Text + " );", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted");
                ClearData();
                List();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some filds are null");
            }
        }

        private void ClearData()
        {
            dateTimePicker1.ResetText();
            TxtQty.Text = TxtSellPrice.Text = TxtReorderleval.Text = TxtName.Text="";
            //throw new NotImplementedException();
        }

        private void medicines_Load(object sender, EventArgs e)
        {
            TxtMedicineNo.Enabled = false;
            List();
        }

        private void List()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            con.Close();
            da = new SqlDataAdapter("select * from tblMedicine;", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //throw new NotImplementedException();
        }

        private void BtnExpire_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            da = new SqlDataAdapter("select * from tblMedicine where ExpiryDate<'"+DateTime.Today+"';", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnVIEW_Click(object sender, EventArgs e)
        {
            TxtMedicineNo.Enabled = true;


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (ComboKey.SelectedIndex == 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    con.Close();
                    da = new SqlDataAdapter("select * from tblMedicine where Qty="+0+";", con);
                    con.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (ComboKey.SelectedIndex == 1)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    con.Close();
                    da = new SqlDataAdapter("select * from tblMedicine where ExpiryDate<'" + DateTime.Today + "';", con);
                    con.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
               
                /*SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Close();
                da = new SqlDataAdapter("select * from tblMedicine where MedicineNo=" + TxtMedicineNo.Text + ";", con);
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;*/
             }
                catch(Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
  
            /*con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("select * from tblMedicine where MedicineNo=" + TxtMedicineNo.Text + "", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            { 
                TxtMedicineNo.Text=dr.GetValue(1).ToString();
                TxtName.Text=dr.GetValue(2).ToString();
             //   dateTimePicker1.Value = dr.GetValue(3).GetType();
                TxtQty.Text=dr.GetValue(4).ToString();
                TxtReorderleval.Text=dr.GetValue(5).ToString();
                TxtSellPrice.Text = dr.GetValue(6).ToString();
            }
            con.Close();*/
        }

        private void ComboKey_DockChanged(object sender, EventArgs e)
        {
            if (ComboKey.SelectedIndex==1)
            {
                MessageBox.Show("Outof stock");
            }
            else if (ComboKey.SelectedIndex == 2)
            {
                MessageBox.Show("Expired");
            }
        }
    }
}
