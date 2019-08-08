using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_Persona
    {
        // LLAMAMOS AL METODO
        public  List<Persona> ObtenerPersona()
        {
            return Capa_Datos.D_Persona.ObtenerPersona();
        }
        // LISTO AHORA A LA CAPA PRESENTACION
    }
}
