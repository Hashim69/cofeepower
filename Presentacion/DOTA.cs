using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class DOTA
    {
        private static DOTA datos;

        private DOTA()
        {
        }

        public static DOTA Instance()
        {
            if (datos == null)
            {
                datos = new DOTA();
            }

            return datos;
        }

        public int IdUser { get; set; }
        public string Name_User { get; set; }
    }
}
