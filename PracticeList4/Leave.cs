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
    public partial class Leave : Form
    {     
        SqlConnection conn = new SqlConnection("Data Source=SAGAR;Initial Catalog=Sample;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
 
        public Leave()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            conn.Close();
            cmd = new SqlCommand("insert into tblLeave values('"+TxtFN.Text+"','"+TxtLN.Text+"',"+tXTeNnO.Text+",'"+TxtCoName.Text+"','"+TxtParentsName.Text+"',"+ComboNoOfDay.Text+",'"+dateTimePickerStartDate.Value+"','"+ToDatePicker.Value+"','"+TxtReason.Text+"');",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record is Successfully Inserted!!!");
            ClearData();
        }

        private void ClearData()
        {
            TxtFN.Text="";
            TxtLN.Text="";
          //  tXTeNnO=006;
            TxtCoName.Text="";
            TxtParentsName.Text="";
            ComboNoOfDay.Text="";
            TxtReason.Text = "";
            //throw new NotImplementedException();
        }
    }
}
