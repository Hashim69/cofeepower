using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Conexion
    {

        public static SqlConnection Abrir()
        {
            SqlConnection Conectar = new SqlConnection("Data Source=.; Initial Catalog = SistRest_BD; Integrated Security = True");
            return Conectar;
        }
        public static int usuario()
        {
            int usuario = 0;
            return usuario;
        }

    }
    public class Variables
    {
        public static int usuarioDB = 0;
        public static int NumCliente = 0;
    }

    

}
