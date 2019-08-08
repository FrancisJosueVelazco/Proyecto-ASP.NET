using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class D_Persona
    {
        // CREANDO EL METODO OBTENER
        public static List<Persona> ObtenerPersona()
        {
            //DEFINIENDO EL TI¨PO DE CONEXION Y LOS OBJETOS
            List<Persona> lstPersona = new List<Persona>();
            SqlConnection cn = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            // DEFINIR LA CADENA Y LA EJECUCION DEL COMANDO
            try
            {   // DAMOS PERMISOS AL COMANDO DE LA CONEXION
                comando.Connection = cn;
                // ABRIMOS LOS RECURSOS
                comando.Connection.Open();
                // INDICAMOS EL TIPO DE PROCEDIMIENTO A EJECUTAR
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // INDICAMOS EL NOMBRE DEL PROCEDIMIENTO
                comando.CommandText = "sp_Obtener";
                // SI EL PROCEDIMIENTO TIENE PARAMETROS AGREGAR LA SIGUIENTE LINEA (EN ESTE CASO NO)
                //comando.Parameters.AddWithValue("", );
                // INDICAMOS AL COMANDO EL TIPO DE EJECUCION
                // USING = USAR RECURSOS O CONSUMIR O LIBERAR
                // DATAREADER ES UN OBJETO DE MODO CONECTADO (ADO.NET)
                using (SqlDataReader lector = comando.ExecuteReader())
                {// UNA VEZ QUE EL COMANDO EJECUTE EL PROCEDIMIENTO, REALIAZAMOS UNA LECTURA
                    while (lector.Read()) // MIENTRAS QUE EXISTAN DATOS -> LEELOS
                    {
                        // INSTANCIAMOS A LA CLASE PERSONA Y REALIZAMOS LA LECTURA
                        Persona objPersona = new Persona();
                        objPersona.codigo = Convert.ToInt32(lector["codigo"]);
                        // SI ENCUENTRA NULOS, TRAEME VACIOS 
                        objPersona.nombres = lector["nombres"] as string ?? "";
                        objPersona.nombres = lector["apellidos"] as string ?? "";
                        objPersona.edad = Convert.ToInt32(lector["edad"]);
                        objPersona.fecha = Convert.ToDateTime(lector["fecha"]);

                        // UNA VEZ TERMINADO EL RECORRIDO, LO LLENAMOS EN LA LISTA
                        lstPersona.Add(objPersona);

                    }
                }

                
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            
            // FINALLY = AL FINALIZAR EL TRY
            finally
            {
                // IMPORTANTE CERRAR LOS RECURSOS 
                cn.Close();
                comando.Dispose();

            }
            // FINALMENTE RETORNAMOS LOS DATOS ---EL RETORNO PUEDE SER TAMBIEN EN EL TRY, YA QUE SIEMPRE VA A PASAR POR EL FINALLY
            return lstPersona;

        }
    }
}
