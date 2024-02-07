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
    public partial class frmSecretaryLogIn : Form
    {
        public frmSecretaryLogIn()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            frmLogIn frm = new frmLogIn();
            frm.Show();
            this.Close();
        }

        sqlCon cnnt = new sqlCon();
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Tbl_Secretary where SecretarySSN=@p1 and SecretaryPassword=@p2", cnnt.connecter());
            cmd.Parameters.AddWithValue("@p1",txt_SSN.Text);
            cmd.Parameters.AddWithValue("@p2",txt_Password.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                frmSecretaryUI frm = new frmSecretaryUI();
                frm.ssn = txt_SSN.Text;
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Uyuşmuyor","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

    }
}
