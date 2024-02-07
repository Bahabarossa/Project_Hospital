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
    public partial class frmPatientLogIn : Form
    {
        public frmPatientLogIn()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            frm.Show();
            this.Close();
        }

        private void lnk_SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientRegister frm = new frmPatientRegister();
            frm.Show();
        }
        sqlCon cnnt = new sqlCon();
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Patient where PatientSSN=@p1 and PatientPassword=@p2",cnnt.connecter());
            cmd.Parameters.AddWithValue("@p1",txt_SSN.Text);
            cmd.Parameters.AddWithValue("@p2",txt_Password.Text);
            //**********************************
            SqlDataReader dr = cmd.ExecuteReader();
            //**********************************
            if (dr.Read())
            {
                frmPatientUI frm = new frmPatientUI();
                frm.ssn = txt_SSN.Text;
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgiler uyuşmuyor.");
            }
            cnnt.connecter().Close();
        }
    }
}
