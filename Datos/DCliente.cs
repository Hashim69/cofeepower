using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DCliente
    {

        //Procedimiento para insertar un nuevo cliente
        //inicio
        public void Cliente_Insert(Entidades.ECliente Cliente)
        {

            SqlConnection coneccion = Conexion.Abrir();//se establece la comunicacion con la clase coneccion
            SqlCommand cmd = new SqlCommand("SP_CatCliente_Insert", coneccion);//se da el nombre del procedimiento almacenado a utilizar
            cmd.CommandType = CommandType.StoredProcedure;//comando del tipo procedimiento almacenado
            //Se le asignan los valores a guardar a cada variable
            cmd.Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = Cliente.Nombres;
            cmd.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = Cliente.Apellidos;
            cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar, 16).Value = Cliente.Cedula;
            cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 80).Value = Cliente.Direccion;
            cmd.Parameters.Add("@Telefono", SqlDbType.Int).Value = Cliente.Telefono;
            cmd.Parameters.Add("@Fechaingreso", SqlDbType.DateTime).Value = Cliente.Fechaingreso;
            cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar, 50).Value = Cliente.observaciones;
            try
            {
                coneccion.Open();//se abre la coneccion con la base de datos
                cmd.ExecuteNonQuery();//se ejecuta el porcedimiento almacenado
                coneccion.Close();//se cierra la coneccion
            }
            catch (Exception)
            {
                throw;
            }
         }//fin


        //Procedimiento para obtener la lista de cliente
        //inicio
        public List<Entidades.ECliente> GetAll()
        {
            SqlConnection coneccion = Conexion.Abrir();
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("SP_CatCliente_Select", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = "";
            cmd.Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = "";
            cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar, 16).Value = "";
            cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 80).Value = "";
            cmd.Parameters.Add("@Telefono", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Fechaingreso", SqlDbType.DateTime).Value = Convert.ToDateTime("2018-02-15");
            cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar, 50).Value = "";
            cmd.Connection = coneccion;
            SqlDataReader leer = cmd.ExecuteReader();
            List<Entidades.ECliente> listaClientes = new List<Entidades.ECliente>();
            while (leer.Read())
            {
                Entidades.ECliente filaCliente = new Entidades.ECliente();
                filaCliente.IdCliente = Convert.ToInt32(leer["IdCliente"].ToString());
                filaCliente.Nombres = leer["Nombres"].ToString();
                filaCliente.Apellidos = leer["Apellidos"].ToString();
                filaCliente.Cedula = leer["Cedula"].ToString();
                filaCliente.Direccion = leer["Direccion"].ToString();
                filaCliente.Telefono = Convert.ToInt32(leer["Telefono"].ToString());
                filaCliente.Fechaingreso = Convert.ToDateTime(leer["Fechaingreso"].ToString());
                filaCliente.observaciones = leer["observaciones"].ToString();
                listaClientes.Add(filaCliente);
            }
            return listaClientes;
         }//fin


        //Procedimiento para actualizar los datos de un cliente
        //inicio
        public void Cliente_Update(Entidades.ECliente Cliente)
        {
            SqlConnection coneccion = Conexion.Abrir();//se establece la comunicacion con la clase coneccion
            SqlCommand cmd = new SqlCommand("SP_CatCliente_Update", coneccion);//se da el nombre del procedimiento almacenado a utilizar
            cmd.CommandType = CommandType.StoredProcedure;//comando del tipo procedimiento almacenado
            //Se le asignan los valores a guardar a cada variable
            cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente);
            cmd.Parameters.AddWithValue("@Nombres", Cliente.Nombres);
            cmd.Parameters.AddWithValue("@Apellidos", Cliente.Apellidos);
            cmd.Parameters.AddWithValue("@Cedula", Cliente.Cedula);
            cmd.Parameters.AddWithValue("@Direccion", Cliente.Direccion);
            cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
            cmd.Parameters.AddWithValue("@Fechaingreso", Cliente.Fechaingreso);
            cmd.Parameters.AddWithValue("@observaciones", Cliente.observaciones);
            try
            {
                coneccion.Open();
                cmd.ExecuteNonQuery();
                coneccion.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }//fin

        //Procedimiento para actualizar los datos de un cliente
        //inicio
        public void Cliente_Delete(Entidades.ECliente Cliente)
        {
            SqlConnection coneccion = Conexion.Abrir();//se establece la comunicacion con la clase coneccion
            SqlCommand cmd = new SqlCommand("SP_CatCliente_Delete", coneccion);//se da el nombre del procedimiento almacenado a utilizar
            cmd.CommandType = CommandType.StoredProcedure;//comando del tipo procedimiento almacenado
            //Se le asignan los valores a guardar a cada variable
            cmd.Parameters.AddWithValue("@IdCliente", Cliente.IdCliente);
            try
            {
                coneccion.Open();
                cmd.ExecuteNonQuery();
                coneccion.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }//fin
    }
}
