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
    public partial class frmSecretaryDoctorPanel : Form
    {
        public frmSecretaryDoctorPanel()
        {
            InitializeComponent();
        }
        sqlCon cnnt = new sqlCon();
        private void frmSecretaryDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doctor",cnnt.connecter());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları combocox a ekleme

            SqlCommand cmd2 = new SqlCommand("Select DepartmantName from Tbl_Departmant", cnnt.connecter());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cbx_Department.Items.Add(dr2[0].ToString());
            }
            cnnt.connecter().Close();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand add = new SqlCommand("insert into Tbl_Doctor (Name,Surname,Departmant,DoctorSSN,Password) values (@p1,@p2,@p3,@p4,@p5)",cnnt.connecter());
            add.Parameters.AddWithValue("@p1",txt_Name.Text);
            add.Parameters.AddWithValue("@p2",txt_Surname.Text);
            add.Parameters.AddWithValue("@p3",cbx_Department.Text);
            add.Parameters.AddWithValue("@p4",mtxt_SSN.Text);
            add.Parameters.AddWithValue("@p5",txt_Password.Text);
            add.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            txt_Name.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txt_Surname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            cbx_Department.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            mtxt_SSN.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txt_Password.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();




        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand del = new SqlCommand("Delete from Tbl_Doctor where DoctorSSN=@p1",cnnt.connecter());
            del.Parameters.AddWithValue("@p1",mtxt_SSN.Text);
            del.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Doctor Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("Update Tbl_Doctor set Name=@p1,Surname=@p2,Departmant=@p3,Password=@p5 where DoctorSSN=@p4", cnnt.connecter());
            update.Parameters.AddWithValue("@p1",txt_Name.Text);
            update.Parameters.AddWithValue("@p2",txt_Surname.Text);
            update.Parameters.AddWithValue("@p3",cbx_Department.Text);
            update.Parameters.AddWithValue("@p4",mtxt_SSN.Text);
            update.Parameters.AddWithValue("@p5",txt_Password.Text);
            update.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Doktor Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cbx_Department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
