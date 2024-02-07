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
using System.Data.Common;

namespace Project_Hospital
{
    public partial class frmSecretaryUI : Form
    {
        public frmSecretaryUI()
        {
            InitializeComponent();
        }
        public string ssn;
        sqlCon cnnt=new sqlCon();

        private void frmSecretaryUI_Load(object sender, EventArgs e)
        {
            lbl_SSN.Text ="SSN: " + ssn;
            //Ad Soyad Ekleme*************
            SqlCommand cmd = new SqlCommand("Select SecretaryNameSurname from Tbl_Secretary where SecretarySSN=@p1", cnnt.connecter());
            cmd.Parameters.AddWithValue("@p1", ssn);
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
            {
                lbl_AllName.Text = dr1[0].ToString();
            }
            cnnt.connecter().Close();

            // Branşları data gride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Departmant",cnnt.connecter());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları data gride aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (Name+' '+Surname) as 'Doctors' ,Departmant from Tbl_Doctor", cnnt.connecter());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşları combocox a ekleme

            SqlCommand cmd2 = new SqlCommand("Select DepartmantName from Tbl_Departmant", cnnt.connecter());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                cbx_Department.Items.Add(dr2[0].ToString());
            }
            cnnt.connecter().Close() ;
        }

        private void btn_MakeAppoint_Click(object sender, EventArgs e)
        {
            SqlCommand makeAppo = new SqlCommand("insert into Tbl_Appointments (Date,Time,Department,Doctor) values(@r1,@r2,@r3,@r4)",cnnt.connecter());
            makeAppo.Parameters.AddWithValue("@r1",mtxt_Date.Text);
            makeAppo.Parameters.AddWithValue("@r2",mtxt_Time.Text);
            makeAppo.Parameters.AddWithValue("@r3",cbx_Department.Text);
            makeAppo.Parameters.AddWithValue("@r4", cbx_Doctor.Text);
            makeAppo.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Randevu oluşturuldu.");




        }

        private void cbx_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_Doctor.Items.Clear();
            SqlCommand addDoc = new SqlCommand("Select Name,Surname from Tbl_Doctor where Departmant=@p1", cnnt.connecter());
            addDoc.Parameters.AddWithValue("@p1", cbx_Department.Text);
            SqlDataReader dr3 = addDoc.ExecuteReader();
            while (dr3.Read())
            {
                cbx_Doctor.Items.Add(dr3[0]+" "+dr3[1]);
            }
        }

        private void btn_SendAnnounc_Click(object sender, EventArgs e)
        {
            SqlCommand anno = new SqlCommand("insert into Tbl_Announcement (Announcement) values (@d1)", cnnt.connecter());
            anno.Parameters.AddWithValue("@d1",rtxt_Announcement.Text);
            anno.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btn_DoctorPanel_Click(object sender, EventArgs e)
        {
            frmSecretaryDoctorPanel drp=new frmSecretaryDoctorPanel();
            drp.Show();
        }

        private void btn_DepartmentPanel_Click(object sender, EventArgs e)
        {
            frmSecretaryDepartmentPanel drp=new frmSecretaryDepartmentPanel();
            drp.Show();
        }

        private void btn_AppointmentList_Click(object sender, EventArgs e)
        {
            frmAppointmentList frmapo= new frmAppointmentList();
            frmapo.Show();
        }

        private void btn_AnnouncementList_Click(object sender, EventArgs e)
        {
            frmAnnouncement frm = new frmAnnouncement();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
