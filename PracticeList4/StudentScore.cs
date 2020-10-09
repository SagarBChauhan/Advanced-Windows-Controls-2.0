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
    public partial class StudentScore : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public StudentScore()
        {
            InitializeComponent();
        }
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
            con.Close();
                int Total = Convert.ToInt32(TxtSubject1.Text) + Convert.ToInt32(TxtSubject2.Text) + Convert.ToInt32(TxtSubject3.Text) + Convert.ToInt32(TxtSubject4.Text) + Convert.ToInt32(TxtSubject5.Text);
                int Percentage = Total * 100 / 500;
                con.Close();
               // cmd = new SqlCommand("insert into tblStudentScore (Name,Samester,Subject1,Subject2,Subject3,Subject4,Subject5,Total,Percentage) Values ('" + TxtName.Text + "'," + ComboSemester.Text + "," + TxtSubject1.Text + "," + TxtSubject2.Text + "," + TxtSubject3.Text + "," + TxtSubject4.Text + "," + TxtSubject5.Text + "," + Total + "," + Percentage + ");", con);
                cmd = new SqlCommand("insert into tblStudentScore  Values ("+TxtEnrollment.Text+"+'" + TxtName.Text + "'," + ComboSemester.Text + "," + TxtSubject1.Text + "," + TxtSubject2.Text + "," + TxtSubject3.Text + "," + TxtSubject4.Text + "," + TxtSubject5.Text + "," + Total + "," + Percentage + ");", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();    

                LblResultTotal.Text = Total.ToString();
                LblResultPercentage.Text = Percentage.ToString();
                MessageBox.Show("Data inserted");
                ClearData();
                DisplayData();
            }
            catch (Exception ex)
            {
              MessageBox.Show("Some Error Raised");
            }

        }

        private void ClearData()
        {
            TxtEnrollment.Text = "";
            TxtName.Text = "";
            ComboSemester.Text = "";
            TxtSubject1.Text = "";
            TxtSubject2.Text = "";
            TxtSubject3.Text = "";
            TxtSubject4.Text = "";
            TxtSubject5.Text = "";
            LblResultTotal.Text = "";
            LblResultPercentage.Text="";


            //throw new NotImplementedException();
        }

        private void StudentScore_Load(object sender, EventArgs e)
        {
            TxtEnrollment.Enabled = false;
            DisplayData();
            BtnDelete.Enabled = false;
            BtnSearch.Enabled = false;
            BtnUpdate.Enabled = false;
            comboBoxSearchListPerameter.Enabled = false;
            btnFetch.Enabled = false;

            
        }

        private void DisplayData()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            da = new SqlDataAdapter("Select * from tblStudentScore;", con);
            con.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //throw new NotImplementedException();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Close();
                int Total = Convert.ToInt32(TxtSubject1.Text) + Convert.ToInt32(TxtSubject2.Text) + Convert.ToInt32(TxtSubject3.Text) + Convert.ToInt32(TxtSubject4.Text) + Convert.ToInt32(TxtSubject5.Text);
                int Percentage = Total * 100 / 500;

                cmd = new SqlCommand("update tblStudentScore set Name='" + TxtName.Text + "',Samester=" + ComboSemester.Text + ",Subject1=" + TxtSubject1.Text + ",Subject2=" + TxtSubject2.Text + ",Subject3=" + TxtSubject3.Text + ",Subject4=" + TxtSubject4.Text + ",Subject5=" + TxtSubject5.Text + ",Total=" + Total + ",Percentage=" + Percentage + " where EnrollmentNo=1;", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data  updated");
                ClearData();
                DisplayData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Provide Enrollment number");
            }
            
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            TxtEnrollment.Enabled = true;
            BtnDelete.Enabled = true;
            BtnSearch.Enabled = true;
            BtnUpdate.Enabled = true;
            comboBoxSearchListPerameter.Enabled = true;
            btnFetch.Enabled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           

            try
            {
                con.Close();
                cmd = new SqlCommand("Select * from tblStudentScore where EnrollmentNo=" + TxtEnrollment.Text + ";", con);
                SqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    TxtEnrollment.Text = dr.GetValue(0).ToString();
                    TxtName.Text = dr.GetValue(1).ToString();
                    ComboSemester.Text = dr.GetValue(2).ToString();
                    TxtSubject1.Text = dr.GetValue(3).ToString();
                    TxtSubject2.Text = dr.GetValue(4).ToString();
                    TxtSubject3.Text = dr.GetValue(5).ToString();
                    TxtSubject4.Text = dr.GetValue(6).ToString();
                    TxtSubject5.Text = dr.GetValue(7).ToString();
                    LblResultTotal.Text = dr.GetValue(8).ToString();
                    LblResultPercentage.Text = dr.GetValue(9).ToString();

                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Provide Enrollment number");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                cmd = new SqlCommand("Delete from  tblStudentScore where EnrollmentNo="+TxtEnrollment.Text+";", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("data deleted");
                ClearData();
                DisplayData();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Provide Enrollment number");
            }
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            String total;
            try 
            {
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();

                da = new SqlDataAdapter("SELECT * FROM tblStudentScore where Samester ="+ComboSemester.Text+" ORDER BY Total DESC ;", con);
                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Specifie semester");
            }
            

            /*
            if (comboBoxSearchListPerameter.TabIndex == 0)
            { 
                
            }
            else if (comboBoxSearchListPerameter.TabIndex == 1)
            { }
            else if (comboBoxSearchListPerameter.TabIndex == 2)
            { }
            else
            {
                MessageBox.Show("Please select Search Perameter");
            }*/
        }
    }
}
