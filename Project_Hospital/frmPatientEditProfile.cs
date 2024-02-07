using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class frmPatientEditProfile : Form
    {
        public frmPatientEditProfile()
        {
            InitializeComponent();
        }
        public string ssnum;
        sqlCon cnnt=new sqlCon();
        private void frmPatientEditProfile_Load(object sender, EventArgs e)
        {
                mtxt_SSN.Text = ssnum;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Patient where PatientSSN=@a1", cnnt.connecter());
            cmd.Parameters.AddWithValue("@a1",mtxt_SSN.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_Name.Text = dr[1].ToString();
                txt_Surname.Text = dr[2].ToString();
                mtxt_Phone.Text = dr[4].ToString();
                txt_Password.Text = dr[5].ToString();
                cbx_Gender.Text = dr[6].ToString();
            }
            cnnt.connecter().Close();


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("update Tbl_Patient set PatientName=@p1,PatientSurname=@p2,PatientSSN=@p3,PatientPhone=@p4,PatientPassword=@p5,PatientGender=@p6 where PatientSSN=@p3", cnnt.connecter());
            cmd2.Parameters.AddWithValue("@p1", txt_Name.Text);
            cmd2.Parameters.AddWithValue("@p2", txt_Surname.Text);
            cmd2.Parameters.AddWithValue("@p3", mtxt_SSN.Text);
            cmd2.Parameters.AddWithValue("@p4", mtxt_Phone.Text);
            cmd2.Parameters.AddWithValue("@p5", txt_Password.Text);
            cmd2.Parameters.AddWithValue("@p6", cbx_Gender.Text);
            cmd2.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Bilgileriniz güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
