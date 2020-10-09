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
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
     
        public Product()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("insert into tblProdMaster values("+maskedTextBoxProdNo.Text+","+TxtDescreption.Text+","+TxtProfitPer.Text+","+TxtQty.Text+","+TxtReorderleval.Text+","+TxtCostPrice.Text+","+TxtSellPrice.Text+");", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted Successfully..");
            ClearData();

        }

        private void ClearData()
        {
            //throw new NotImplementedException();
            maskedTextBoxProdNo.Text="";
            TxtDescreption.Text = "";
            TxtProfitPer.Text = "";
            TxtQty.Text = "";
            TxtReorderleval.Text = "";
            TxtCostPrice.Text = "";
            TxtSellPrice.Text = "";
        }

        private void Product_Load(object sender, EventArgs e)
        {
            maskedTextBoxProdNo.Enabled = false;
            BindProduct();

        }

        private void BindProduct()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            con.Close();
            da = new SqlDataAdapter("select * from tblProdMaster", con);

            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //throw new NotImplementedException();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Close();
                cmd = new SqlCommand("select * from tblProdMaster where id=" + maskedTextBoxProdNo.Text + ";", con);
                SqlDataReader dr;

                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    maskedTextBoxProdNo.Text = dr.GetValue(1).ToString();
                    TxtDescreption.Text = dr.GetValue(2).ToString();
                    TxtProfitPer.Text = dr.GetValue(3).ToString();
                    TxtQty.Text = dr.GetValue(4).ToString();
                    TxtReorderleval.Text = dr.GetValue(5).ToString();
                    TxtCostPrice.Text = dr.GetValue(6).ToString();
                    TxtSellPrice.Text = dr.GetValue(7).ToString();
                    
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVIEW_Click(object sender, EventArgs e)
        {
            maskedTextBoxProdNo.Enabled = true;
        }
    }
}
