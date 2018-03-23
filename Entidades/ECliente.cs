using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECliente
    {


        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime Fechaingreso { get; set; }
        public string observaciones { get; set; }
        public string op { get; set; }


    }
}
