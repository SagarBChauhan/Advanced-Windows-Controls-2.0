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
    public partial class JobMaster : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        String Radio = "", Entry = "", Delivery = "";

        public JobMaster()
        {
            InitializeComponent();
           
        }


        private void JobMaster_Load(object sender, EventArgs e)
        {

            DataDisplay();
            TxtJobno.Enabled = false;
            //BtnSearch.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            BtnFetch.Enabled = false;

        }

        private void BtnView_Click(object sender, EventArgs e)
        {

          //  StudentScore stc = new StudentScore();
            //stc.Show();
            //this.Hide();
            TxtJobno.Enabled = true;
            BtnSearch.Enabled = true;
            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            BtnFetch.Enabled = true;
            DataDisplay();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string Radio = "No";
            if (radioButtonNO.Checked)
                Radio = "No";
            else if (radioButtonYes.Checked)
                Radio = "Yes";
            try
            {
                con.Close();
                cmd = new SqlCommand("insert into tblJob_master (vehicle_no,attend,typeofjob,job_description,entry_date,delivery_date) values(" + TxtVehicleNo.Text + ",'" + Radio + "','" + COmboTypeOfJOb.Text + "','" + TxtJobDesc.Text + "','" + dateTimePickerEntry.Value + "','" + dateTimePickerDelivery.Value + "'); ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Inserted");
                DataDisplay();
                ClearData();
            }
            catch(Exception ex)
            { MessageBox.Show("Error");}
        }

        private void RadioResult()
        {

            //throw new NotImplementedException();
        }

        private void ClearData()
        {
            TxtJobno.Text = "";
            TxtVehicleNo.Text = "";           
            COmboTypeOfJOb.Text = ""; 
            TxtJobDesc.Text = ""; 
            //throw new NotImplementedException();
        }

        private void DataDisplay()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            da = new SqlDataAdapter("Select * from tblJob_master;", con);
            con.Open();
            da.Fill(dt);
            dataGridViewJobMAster.DataSource = dt;
            con.Close();
            //throw new NotImplementedException();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try {
                
               // SpecificSearch();
               
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                con.Close();
                da = new SqlDataAdapter("Select * from tblJob_master where vehicle_no like " + TxtVehicleNo.Text + " or typeofjob like'" + COmboTypeOfJOb.Text + "';", con);
                con.Open();
                da.Fill(dt);
                dataGridViewJobMAster.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter vehicle_no and Select Type of job");
            }
            
           
        }

        private void SpecificSearch()
        {

            con.Close();
            SqlDataReader dr;
            cmd = new SqlCommand("Select * from tblJob_master where job_no=" + TxtJobno.Text + " ;", con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                TxtVehicleNo.Text = dr.GetValue(1).ToString();
                Radio = dr.GetValue(2).ToString();
                if (Radio == "Yes")
                {
                    radioButtonYes.Checked = true;
                }
                else if (Radio == "No")
                {
                    radioButtonNO.Checked = true;
                }
                COmboTypeOfJOb.Text = dr.GetValue(3).ToString();
                TxtJobDesc.Text = dr.GetValue(4).ToString();
                Entry = dr.GetValue(5).ToString();
                Delivery = dr.GetValue(6).ToString();
                dateTimePickerDelivery.Value = Convert.ToDateTime(Entry);
                dateTimePickerDelivery.Value = Convert.ToDateTime(Delivery);
            }
            else
            {
                MessageBox.Show("NO RECODE FOUND");
            }
            con.Close();
            //throw new NotImplementedException();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Data will be changed in Database", "Update", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                string Radio = "No";
                if (radioButtonNO.Checked)
                    Radio = "No";
                else if (radioButtonYes.Checked)
                    Radio = "Yes";
                con.Close();
                cmd = new SqlCommand("update tblJob_master set vehicle_no=" + TxtVehicleNo.Text + ",attend='" + Radio + "',typeofjob='" + COmboTypeOfJOb.Text + "',job_description='" + TxtJobDesc.Text + "',entry_date='" + dateTimePickerEntry.Value + "' ,delivery_date='" + dateTimePickerDelivery.Value + "'  where job_no =" + TxtJobno.Text + ";", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated");
                DataDisplay();
                ClearData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you Really want to Delete..?", "Deleted", MessageBoxButtons.YesNoCancel);
            if(dialog == DialogResult.Yes)
            {
                {
                    //SpecificSearch();
                    try
                    {
                        con.Close();
                        cmd = new SqlCommand("delete from tblJob_master where job_no=" + TxtJobno.Text + "", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Deleted");
                        DataDisplay();
                        ClearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void BtnFetch_Click(object sender, EventArgs e)
        {
            SpecificSearch();
        }

        private void dataGridViewJobMAster_MouseClick(object sender, MouseEventArgs e)
        {
           try
            {
                TxtJobno.Text = dataGridViewJobMAster.SelectedRows[0].Cells[0].Value.ToString();
                TxtVehicleNo.Text = dataGridViewJobMAster.SelectedRows[0].Cells[1].Value.ToString();
                Radio = dataGridViewJobMAster.SelectedRows[0].Cells[2].Value.ToString();
                if (Radio == "Yes")
                {
                    radioButtonYes.Checked = true;
                }
                else if (Radio == "No")
                {
                    radioButtonNO.Checked = true;
                }    
                
                
                COmboTypeOfJOb.Text = dataGridViewJobMAster.SelectedRows[0].Cells[3].Value.ToString();
                TxtJobDesc.Text = dataGridViewJobMAster.SelectedRows[0].Cells[4].Value.ToString();
                Entry = dataGridViewJobMAster.SelectedRows[0].Cells[5].Value.ToString();
                Delivery = dataGridViewJobMAster.SelectedRows[0].Cells[6].Value.ToString();
                dateTimePickerDelivery.Value = Convert.ToDateTime(Entry);
                dateTimePickerDelivery.Value = Convert.ToDateTime(Delivery);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Magaj mari na kar");
            }
        }

        private void dataGridViewJobMAster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("cell click no allowd");
        }

        private void dateTimePickerEntry_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
