using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCliente
    {
        //Su funcion es enviar los datos de un nuevo cliente para ser registrado
        public void GuardarNuevo(Entidades.ECliente cliente)
        {
            if (cliente.Nombres == "")
                throw new ArgumentException("Ingrese el nombre del cliente");
            if (cliente.Apellidos == "")
                throw new ArgumentException("Ingrese el apellido del cliente");
            if (cliente.Cedula == "")
                throw new ArgumentException("Digite la cedula del cliente");
            if (cliente.Direccion == "")
                throw new ArgumentException("Ingrese la direccion del domicilio del cliente");
            if (cliente.Telefono == 0)
                throw new ArgumentException("Digite el numero de telefono del cliente");
            Datos.DCliente guardarCliente = new Datos.DCliente();
            guardarCliente.Cliente_Insert(cliente);
        }

        //Obtiene los registros en la tabla cliente
        public List<Entidades.ECliente> ObtenerListaCliente()
        {
            Datos.DCliente getCliente = new Datos.DCliente();
            return getCliente.GetAll();
        }

        //Actualizar los datos de un cliente
        public void Modificar(Entidades.ECliente cliente)
        {
            if (cliente.Nombres == "")
                throw new ArgumentException("Ingrese la Razon Social");
            if (cliente.Apellidos == "")
                throw new ArgumentException("Ingrese el Ruc");
            if (cliente.Cedula == "")
                throw new ArgumentException("Digite su nombre");
            if (cliente.Direccion == "")
                throw new ArgumentException("Digite su Apellido");
            if (cliente.Telefono == 0)
                throw new ArgumentException("Digite su numero de telefono");
            Datos.DCliente guardarCliente = new Datos.DCliente();
            guardarCliente.Cliente_Update(cliente);
        }

        //Para eliminar un registro
        public void Eliminar(Entidades.ECliente cliente)
        {
            Datos.DCliente clienteElimiar = new Datos.DCliente();
            if (cliente.IdCliente == 0)
                throw new ArgumentException("No se obtuvo el id del usuario, intente de nuevo");
            clienteElimiar.Cliente_Delete(cliente);
        }
    }
}
