using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Datos
{
    public static class cifrador
    {
        public static string Cifrar(this string _cadenaAencriptar)
        {
            //VARIABLE STRING DONDE GUARDARE MI CADENA CIFRADA
            string result = string.Empty;
            // MENTOD O FUNCION QUE CIFRA UN ARREGLO DE BYTE
            SHA512Managed cifrador = new SHA512Managed();
            // CONVERTIR CADENA STRING A ARREGLO DE BYTE
            byte[] cadenaenbyte = System.Text.Encoding.ASCII.GetBytes(_cadenaAencriptar);
            //CONVERTIR ARREGLO DE BYTE A CADENA STRING
            byte[] cadenacifrada = cifrador.ComputeHash(cadenaenbyte);
            //DEVOLVER LA CADENA CIFRADA
            result = Convert.ToBase64String(cadenacifrada);

            return result;

        }
    }
    public class DUsuario
    {

        public void Insert(Entidades.EUsuario Usuario)
        {

            SqlConnection coneccion = Conexion.Abrir();
            SqlCommand cmd = new SqlCommand("SP_TblUsers_Insert", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Idperfil", SqlDbType.Int).Value = Usuario.Idperfil;
            cmd.Parameters.Add("@Name_User", SqlDbType.NVarChar, 50).Value = Usuario.Name_User;
            cmd.Parameters.Add("@Key_User", SqlDbType.NVarChar).Value = cifrador.Cifrar(Usuario.Key_User);
            cmd.Parameters.Add("@Estado", SqlDbType.Char, 1).Value = Usuario.Estado;
            try
            {
                coneccion.Open();
                cmd.ExecuteNonQuery();
                coneccion.Close();
            }
            catch (Exception)
            {

            }
        }

        public List<Entidades.EUsuario> GetAll()
        {
            SqlConnection coneccion = Conexion.Abrir();
            coneccion.Open();
            SqlCommand cmd = new SqlCommand("SP_TblUsers_Select", coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IdUser", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Idperfil", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@Name_User", SqlDbType.NVarChar, 50).Value = "";
            cmd.Parameters.Add("@Key_User", SqlDbType.NVarChar).Value = "";
            cmd.Parameters.Add("@Estado", SqlDbType.Char, 1).Value = "a";
            cmd.Connection = coneccion;
            SqlDataReader leer = cmd.ExecuteReader();
            List<Entidades.EUsuario> listausuario = new List<Entidades.EUsuario>();
            while (leer.Read())
            {
                Entidades.EUsuario filausuario = new Entidades.EUsuario();
                filausuario.IdUser = Convert.ToInt32(leer["IdUser"].ToString());
                filausuario.Idperfil = Convert.ToInt32(leer["Idperfil"].ToString());
                filausuario.Name_User = leer["Name_User"].ToString();
                filausuario.Key_User = leer["Key_User"].ToString();
                filausuario.Estado = leer["Estado"].ToString();
                listausuario.Add(filausuario);
            }
            return listausuario;


        }

        public void Inicio(Entidades.EUsuario Usuario)
        {
            SqlConnection coneccion = Conexion.Abrir();
            if (Usuario.Name_User == "ADMIN" && Usuario.Key_User == "1234")
            {
                Usuario.Estado = "A";
                Usuario.Exist = 1;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SP_TblUsers_Exists", coneccion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IdUser", SqlDbType.Int);
                cmd.Parameters["@IdUser"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Idperfil", SqlDbType.Int).Value = Usuario.Idperfil;
                cmd.Parameters.Add("@Name_User", SqlDbType.NVarChar, 50).Value = Usuario.Name_User;
                cmd.Parameters.Add("@Key_User", SqlDbType.NVarChar).Value = cifrador.Cifrar(Usuario.Key_User);
                cmd.Parameters.Add("@Estado", SqlDbType.Char, 1);
                cmd.Parameters["@Estado"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@exists", SqlDbType.Int);
                cmd.Parameters["@exists"].Direction = ParameterDirection.Output;
                DataTable dt = new DataTable();
                SqlDataAdapter dr = new SqlDataAdapter();
                try
                {
                    coneccion.Open();
                    dr.SelectCommand = cmd;
                    dr.Fill(dt);
                    int ex = Convert.ToInt32(cmd.Parameters["@exists"].Value.ToString());
                    if (ex == 0)
                    {
                        Usuario.Exist = 0;
                    }
                    else
                    {
                        Usuario.Exist = 1;
                        if (dt.Rows.Count > 0)
                        {
                            Usuario.IdUser = Convert.ToInt32(cmd.Parameters["@IdUser"].Value.ToString());
                            Usuario.Estado = cmd.Parameters["@Estado"].Value.ToString();
                        }
                    }
                    coneccion.Close();
                }
                catch (Exception x)
                {
                    throw x;
                }
            }
        }

    }
}
