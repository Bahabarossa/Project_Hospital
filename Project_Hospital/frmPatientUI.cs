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
    public partial class frmPatientUI : Form
    {
        public frmPatientUI()
        {
            InitializeComponent();
        }

        public string ssn;
        sqlCon cnnt  = new sqlCon();

        private void frmPatientUI_Load(object sender, EventArgs e)
        {
            Lbl_ID.Text ="SSN: " +ssn;
            // Ad Soyad Çekme...
            SqlCommand cmd = new SqlCommand("Select PatientName,PatientSurname From Tbl_Patient where PatientSSN=@a1", cnnt.connecter());
            cmd.Parameters.AddWithValue("@a1",ssn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Lbl_AllName.Text = dr[0] + " " + dr[1]; 
            }
            cnnt.connecter().Close();

            //************************
            //Randevu Geçmişi...
            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("Select * from Tbl_Appointments where PatientSSN="+ssn,cnnt.connecter());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // dt diye table oluşturduk da diye data adapter oluşturduk bilgileri buna attık, da attığımız bilgileri de dt ye fill ( doldurduk ) yaptık
            //************************
            //Branşları çekme...
            SqlCommand cmd2 = new SqlCommand("Select DepartmantName from Tbl_Departmant",cnnt.connecter());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                cbx_Departmant.Items.Add(dr2[0]);
            }
         
        }

        private void cbx_Departmant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //************************
            //Branş seçimine göre doktor çekme
            cbx_Doctor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select Name,Surname from Tbl_Doctor where Departmant=@p1", cnnt.connecter());
            cmd3.Parameters.AddWithValue("@p1", cbx_Departmant.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cbx_Doctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            cnnt.connecter().Close();
        }

        private void cbx_Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {   
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where Department='"+cbx_Departmant.Text+"' and Doctor='"+cbx_Doctor.Text+"'and state=0" ,cnnt.connecter());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            
        }

        private void Lnk_Profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientEditProfile frm = new frmPatientEditProfile();
            frm.ssnum=ssn;
            frm.Show();
        }



        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Appointments Set state=1 ,PatientSSN=@p1 ,PatientExplain=@p2 where ID=@p3", cnnt.connecter());
            cmd.Parameters.AddWithValue("@p1",ssn);
            cmd.Parameters.AddWithValue("@p2",rtxt_illnes.Text);
            cmd.Parameters.AddWithValue("@p3",txt_randevuID.Text);
            cmd.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Randevu Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txt_randevuID.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
