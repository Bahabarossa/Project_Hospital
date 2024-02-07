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
    public partial class frmSecretaryDepartmentPanel : Form
    {
        public frmSecretaryDepartmentPanel()
        {
            InitializeComponent();
        }

        sqlCon cnnt = new sqlCon();

        private void frmSecretaryDepartmentPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Departmant",cnnt.connecter());
            da.Fill(dt);
            dataGridView1.DataSource=dt;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Departmant (DepartmantName)values(@p1)",cnnt.connecter());
            cmd.Parameters.AddWithValue("@p1",txt_Name.Text);
            cmd.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Branş eklendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ID.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand del = new SqlCommand("Delete from Tbl_Departmant where DepartmantID=@p1", cnnt.connecter());
            del.Parameters.AddWithValue("@p1",txt_ID.Text);
            del.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Branş silindi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update Tbl_Departmant set DepartmantName=@p1 where DepartmantID=@p2", cnnt.connecter());
            update.Parameters.AddWithValue("@p1",txt_Name.Text);
            update.Parameters.AddWithValue("@p2",txt_ID.Text.ToString());
            update.ExecuteNonQuery();
            cnnt.connecter().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }
    }
}
