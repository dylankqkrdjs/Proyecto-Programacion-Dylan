using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFokus
{
    internal class ModeloUsuarios
    {
        private Conexion miConexion;
        private MySqlConnection conectar;
        private String sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;
        public bool existeUsuario(Usuario user)
        {
            bool rta = false;
            miConexion = new Conexion();
            conectar = miConexion.ObtenerConexion();
            conectar.Open();
            sql = "SELECT * FROM usuarios WHERE Nombre_usuario Like @Nombre_usuario";
            comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@Nombre_usuario", user.Nombre);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            conectar.Close();
            return rta;
        }
        public bool ValidarLogin(Usuario usuario)
        {
            Controlador control = new Controlador();
            bool resultado = false;
            string conexion = "server=localhost;port=3306;database=fokusdb;uid=root;pwd=Fokus4321@!M";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM usuarios WHERE Gmail = @correo AND contraseña = @contraseña";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // 🔥 Genero el hash de la contraseña ingresada
                        string passwordHash = control.generarSHA1(usuario.Password);

                        cmd.Parameters.AddWithValue("@correo", usuario.Gmail);
                        cmd.Parameters.AddWithValue("@contraseña", passwordHash);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int count = Convert.ToInt32(result);
                            resultado = (count > 0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en validar login: " + ex.Message);
            }
            return resultado;

        }
           
        public bool registrarUsuario(Usuario user)
        {
            miConexion = new Conexion();
            conectar = miConexion.ObtenerConexion();
            conectar.Open();
            sql = "INSERT INTO usuarios (Id_usuario,Nombre_usuario, contraseña,Apellido,Gmail)" +
            " VALUES (@Id_usuario,@Nombre_usuario,@contraseña,@Apellido,@Gmail)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@Id_usuario", null);
            comando.Parameters.AddWithValue("@Nombre_usuario", user.Nombre);
            comando.Parameters.AddWithValue("@contraseña", user.Password);
            comando.Parameters.AddWithValue("@Apellido",user.Apellido);
            comando.Parameters.AddWithValue("@Gmail",user.Gmail);

            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }
    }
}
