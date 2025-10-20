using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFokus
{
    internal class ModeloDeTareas
    {
        private string conexion = "server=localhost;port=3306;database=fokusdb;uid=root;pwd=Fokus4321@!M";

        public bool InsertarTarea(Tareas tarea)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = @"INSERT INTO tareas 
                              (gmail, titulo, descripcion, categoria, fecha_inicio tarea_completada)
                              VALUES (@gmail, @titulo, @descripcion, @categoria, @inicio, @completada)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@gmail", tarea.Gmail);
                        cmd.Parameters.AddWithValue("@titulo", tarea.Titulo);
                        cmd.Parameters.AddWithValue("@descripcion", tarea.Descripcion);
                        cmd.Parameters.AddWithValue("@categoria", tarea.Categoria);
                        cmd.Parameters.AddWithValue("@inicio", tarea.FechaInicio);
                        
                        cmd.Parameters.AddWithValue("@completada", tarea.TareaCompletada ? "completada" : "pendiente");
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tarea: " + ex.Message);
                return false;
            }
        }

        public List<Tareas> ObtenerTareasPorUsuario(string gmail)
        {
            List<Tareas> tareas = new List<Tareas>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = "SELECT * FROM tareas WHERE gmail = @gmail";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@gmail", gmail);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tareas.Add(new Tareas
                                {
                                    IdTarea = reader.GetInt32("idTarea"),
                                    Gmail = reader.GetString("gmail"),
                                    Titulo = reader.GetString("titulo"),
                                    Descripcion = reader.GetString("descripcion"),
                                    Categoria = reader.GetString("categoria"),
                                    FechaInicio = reader.GetDateTime("fecha_inicio"),
                                    
                                    TareaCompletada = reader.GetBoolean("tarea_completada")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener tareas: " + ex.Message);
            }
            return tareas;
        }
    }
}
