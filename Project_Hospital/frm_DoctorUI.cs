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
    public partial class frm_DoctorUI : Form
    {
        public frm_DoctorUI()
        {
            InitializeComponent();
        }
        sqlCon cnnt = new sqlCon();
        public string ssn;
        private void frm_DoctorUI_Load(object sender, EventArgs e)
        {
            // Giriş ekranındaki ssn yi buraya çekme yukarda ssn yi tanımladık
            lbl_SSN.Text ="SSN :" + ssn;

            //Doktorun adı soyadını çekme
            SqlCommand cmd = new SqlCommand("Select Name,Surname from Tbl_Doctor where DoctorSSN=@p1",cnnt.connecter());
            cmd.Parameters.AddWithValue("@p1", ssn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_AllName.Text = dr[0] + " " + dr[1];
            }
            cnnt.connecter().Close();
            //Doktorun kendi randevu listesini gösterme.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointments where Doctor= '"+lbl_AllName.Text+"'",cnnt.connecter());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btn_Annonce_Click(object sender, EventArgs e)
        {
            frmAnnouncement frm = new frmAnnouncement();
            frm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            rtxt_IllDescript.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
