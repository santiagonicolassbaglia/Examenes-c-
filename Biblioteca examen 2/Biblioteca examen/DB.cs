
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Archivos;

namespace Biblioteca_examen
{
    public static  class DB
    {



        static SqlConnection conectarAlDB;



        static DB()
        {
            conectarAlDB = new SqlConnection("Server=.;Database=ProductosDB;Trusted_Connection=True;");
        }



        //valida usuario


        public static Cliente validaUsuario(string usuario, string pass)
        {
            SqlCommand commandd;
            commandd = new SqlCommand();
            SqlConnection sqlConnection;
            string connectionString = "Server=.;Database=ProductosDB;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(connectionString);

            string sql = "select * from Clientes  where  usuario = @usuario and contraseña = @password";
            commandd.CommandText = sql;
            commandd.Parameters.Clear();
            commandd.Parameters.Add(new SqlParameter("@usuario", usuario));
            commandd.Parameters.Add(new SqlParameter("@password", pass));

            commandd.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                SqlDataReader dr = commandd.ExecuteReader(); // envia a la base de datos , lo ejecuta y recibe la respuesta.. la motito
                if (dr.Read())
                {

                    Cliente user = new Cliente("Santiago", 4080800, "santi", "1234", "sbaglia");
                    user.Usuario = usuario;
                    user.Dni = int.Parse(dr["Dni"].ToString());

                    user.Nombre = dr["Nombre"].ToString();
                    user.Apellido = dr["Apellido"].ToString();
                    user.Contrasenia = pass;

                    return user;
                }
                else
                    return null;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                sqlConnection.Close();
            }

        }






        public static string CreateMD5(string input) // genera un string .. es para validacion de contenido. 
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
















    }




}
