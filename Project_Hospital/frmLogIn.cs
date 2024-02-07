using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            frmPatientLogIn frm = new frmPatientLogIn();
            frm.Show();
            this.Hide();
        }

        private void btn_Doctor_Click(object sender, EventArgs e)
        {
            frm_DoctorLogIn frm = new frm_DoctorLogIn();
            frm.Show();
            this.Hide();
        }

        private void btn_Secretary_Click(object sender, EventArgs e)
        {
            frmSecretaryLogIn frm = new frmSecretaryLogIn();
            frm.Show();
            this.Hide();
        }
    }
}
