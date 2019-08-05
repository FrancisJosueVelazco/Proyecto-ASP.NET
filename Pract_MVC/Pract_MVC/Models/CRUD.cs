using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Pract_MVC.Models
{
    public class CRUD
    {
        public DataTable listar()
        {
            DataTable dt = new DataTable();
            string Conn = @"Data Source=DESKTOP\MSSQLEXPRESS; Initial Catalog=BD_QG; Integrated Security=True";
            using (SqlConnection con = new SqlConnection(Conn))
            {
                con.Open();
                //Querys
                SqlCommand cmd = new SqlCommand("Select * from Persona", con);
                //
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
    }
}