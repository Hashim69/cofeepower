using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUsuario
    {

            public int IdUser { get; set; }
            public int Exist { get; set; }
            public int Idperfil { get; set; }
            public string Name_User { get; set; }
            public string Key_User { get; set; }
            public string Estado { get; set; }

    }
}
