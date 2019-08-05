using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vistas.Models
{
    public class Clientes
    {
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public DateTime fecha { get; set; }
        public string direccion { get; set; }

    }
}