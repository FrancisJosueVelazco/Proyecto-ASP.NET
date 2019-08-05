using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Pract_MVC.Models
{
    public class Connection
    {

        public void Conexion()
        {
            string Conn = @"Data Source=DESKTOP\MSSQLEXPRESS; Initial Catalog=BD_QG; Integrated Security=True";
            SqlConnection c = new SqlConnection(Conn);
        }
    }
}