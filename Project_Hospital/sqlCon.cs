using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_Hospital
{
    internal class sqlCon
    {
        public SqlConnection connecter()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8OB7L2D\\WINCC;Initial Catalog=HospitalProject;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
