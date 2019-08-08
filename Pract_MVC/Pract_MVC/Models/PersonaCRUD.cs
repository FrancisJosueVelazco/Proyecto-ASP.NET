using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Pract_MVC.Models
{
    public class PersonaCRUD
    {
        string Conn = @"Data Source=DESKTOP\MSSQLEXPRESS; Initial Catalog=BD_QG; Integrated Security=True";
        
         public DataTable listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conn))
            {
                con.Open();
                //Querys
                SqlCommand cmd = new SqlCommand("Select * from Persona", con);
                //Recupera y Guarda Datos
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close(); 
            }
            return dt;
        }
    
        public DataTable ListarxID(int codigo){
            DataTable dt=new DataTable();
            using(SqlConnection c=new SqlConnection(Conn))
            {
                string query="SELECT * FROM Persona WHERE codigo="+codigo;
                SqlCommand cmd=new SqlCommand(query,c);
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }


        public int Registrar(string nombre, string apellido, int edad,  string direccion,DateTime fecha)
        {
            using (SqlConnection c = new SqlConnection(Conn))
            {
                c.Open();
                string query = "INSERT INTO Persona(nombres,apellidos,edad,fecha,direccion) VALUES (@nombres,@apellidos,@edad,@fecha,@direccion)";
                SqlCommand cmd = new SqlCommand(query, c);
                cmd.Parameters.AddWithValue("@nombres", nombre);
                cmd.Parameters.AddWithValue("@apellidos", apellido);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                

                return cmd.ExecuteNonQuery();

            }
        }

        public int Editar(int codigo,string nombre, string apellido, int edad, string direccion, DateTime fecha)
        {
            using (SqlConnection c = new SqlConnection(Conn))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = c;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_Actualizar";

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@nombres", nombre);
                cmd.Parameters.AddWithValue("@apellidos", apellido);
                cmd.Parameters.AddWithValue("@edad", edad);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                

                return cmd.ExecuteNonQuery();

            }

           

            
        }

        public int Eliminar(int codigo)
        {
            using (SqlConnection c = new SqlConnection(Conn))
            {
                c.Open();
                string query = "DELETE FROM Persona WHERE codigo=@codigo";
                SqlCommand cmd = new SqlCommand(query, c);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                

                return cmd.ExecuteNonQuery();

            }
        }
    }
}