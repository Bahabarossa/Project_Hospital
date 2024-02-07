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
    public partial class frmAppointmentList : Form
    {
        public frmAppointmentList()
        {
            InitializeComponent();
        }
        sqlCon cnnt = new sqlCon();


        private void frmAppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("select * from Tbl_Appointments",cnnt.connecter());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
     
    }
}
