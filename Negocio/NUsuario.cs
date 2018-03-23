using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuario
    {

        public void GuardarNuevo(Entidades.EUsuario usuario)
        {
            if (usuario.Name_User == "")
                throw new ArgumentException("Ingrese el Nombre de usuario");
            if (usuario.Key_User == "")
                throw new ArgumentException("Ingrese la contraseña");
            Datos.DUsuario guardarusuario = new Datos.DUsuario();
            guardarusuario.Insert(usuario);
        }
        public void Validarusuario(Entidades.EUsuario usuario)
        {
            if (usuario.Name_User == "")
                throw new ArgumentException("Ingrese el Nombre de usuario");
            if (usuario.Key_User == "")
                throw new ArgumentException("Ingrese la contraseña");
            Datos.DUsuario login = new Datos.DUsuario();
            login.Inicio(usuario);
        }

        public List<Entidades.EUsuario> ObtenerListaUsuario()
        {
            Datos.DUsuario getUsuario = new Datos.DUsuario();
            return getUsuario.GetAll();
        }
        public void Modificar(Entidades.EUsuario usuario)
        {
            if (usuario.Name_User == "")
                throw new ArgumentException("Ingrese el login");
            if (usuario.Key_User == "")
                throw new ArgumentException("Ingrese la contraseña");
            Datos.DUsuario guardarusuario = new Datos.DUsuario();
            //guardarusuario.Accion(usuario);
        }
        public void Eliminar(Entidades.EUsuario usuario)
        {
            Datos.DUsuario DUsuarioeliminar = new Datos.DUsuario();
            //DUsuarioeliminar.Accion(usuario);
        }

    }
}
