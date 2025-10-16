using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoFokus
{
    public class Conexion

    {
        private const string servidor = "datasource=127.0.0.1";
        private const string puerto = "port=3306";
        private const string username = "username=root";
        private const string pass = "password=Fokus4321@!M";
        private const string BD = "database=FokusDB";

        private string cadenaconexion;

        public Conexion() {

            cadenaconexion = servidor + ";" + puerto + ";" + username + ";" + pass + ";" + BD;
             using (MySqlConnection conn = new MySqlConnection(cadenaconexion)) 
                try
                {
                    conn.Open();
                    Console.WriteLine("Conexion exitosa con la base de datos");

                }
                catch
                {
                    Console.WriteLine("Error de conexion");
                }

        }
       
        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaconexion);
        }


    }
}
