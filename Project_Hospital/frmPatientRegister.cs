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

namespace Project_Hospital
{
    public partial class frmPatientRegister : Form
    {
        public frmPatientRegister()
        {
            InitializeComponent();
        }
        sqlCon cnnt = new sqlCon();

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Patient(PatientName,PatientSurname,PatientSSN,PatientPhone,PatientPassword,PatientGender) values(@p1,@p2,@p3,@p4,@p5,@p6)", cnnt.connecter());
            cmd.Parameters.AddWithValue("@p1",txt_Name.Text);
            cmd.Parameters.AddWithValue("@p2",txt_Surname.Text);
            cmd.Parameters.AddWithValue("@p3",mtxt_SSN.Text);
            cmd.Parameters.AddWithValue("@p4",mtxt_Phone.Text);
            cmd.Parameters.AddWithValue("@p5",txt_Password.Text);
            cmd.Parameters.AddWithValue("@p6",cbx_Gender.Text);
            cmd.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show ("Kaydınız Gerçekleşmiştir\nŞifreniz:" + txt_Password.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
