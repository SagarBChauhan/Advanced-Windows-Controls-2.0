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
    public partial class Enrollment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Enrollment()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("insert into tblEnnrollment values(1,' sagar','MscIt','5 years','25250','2018/02/17');", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("submition done..");
            ClearData();

        }

        private void ClearData()
        {
            MAskTxtENroll.Text = "";
            LblName.Text = "";

            //throw new NotImplementedException();
        }
    }
}
