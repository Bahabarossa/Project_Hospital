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
    public partial class frm_DoctorLogIn : Form
    {
        public frm_DoctorLogIn()
        {
            InitializeComponent();
        }
        sqlCon cnnt = new sqlCon();

        private void btn_return_Click(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            frm.Show();
            this.Close();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doctor where DoctorSSN=@p1 and Password=@p2",cnnt.connecter());
            cmd.Parameters.AddWithValue("@p1", txt_SSN.Text);
            cmd.Parameters.AddWithValue("@p2", txt_Password.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frm_DoctorUI fr = new frm_DoctorUI();
                fr.ssn = txt_SSN.Text;
                fr.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Hatalı tc veya şifre","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            cnnt.connecter().Close();

        }
    }
}
