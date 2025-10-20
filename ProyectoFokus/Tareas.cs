using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFokus
{
    internal class Tareas
    {
        public int IdTarea { get; set; }
        public string Titulo { get; set; }
        public string Gmail { get; set; }
        public DateTime fecha { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public TimeSpan TiempoTrabajado { get; set; } = TimeSpan.Zero;
        public int TiempoEstimado { get; set; }
        public string Categoria { get; set; }
        public bool TareaCompletada { get; set; } = false;
        public static int Racha => racha;
       
        private static int racha = 0;

        private static DateTime? UltimaFechaCompletada = null;
        public Tareas() { }
        public static void ActualizarRacha(DateTime fecha)
        {
            if (UltimaFechaCompletada == null)
            {
                racha = 1;
                UltimaFechaCompletada = fecha.Date;
            }
            else
            {
                if (UltimaFechaCompletada.Value.Date == fecha.Date)
                {
                    return;
                }
                if (UltimaFechaCompletada.Value.Date.AddDays(1) == fecha.Date)
                {
                    racha++;
                }
                else
                { racha = 1; }
                UltimaFechaCompletada = fecha.Date;
            }
        }
        public Tareas (bool tareacom,DateTime fech)
        {
            this.TareaCompletada = tareacom;
            this.fecha = fech;

        }
        public Tareas(string titulo, string descripcion, DateTime inicio, DateTime fin)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            FechaInicio = inicio;
            FechaFin = fin;
           
        }
        public Tareas(string titulo, string descripcion, DateTime inicio, DateTime fin,int tiempoestimado)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            FechaInicio = inicio;
            FechaFin = fin;
            TiempoEstimado = tiempoestimado;

        }
        public Tareas(string titulo, string descripcion, DateTime inicio, DateTime fin, int tiempoestimado,string cat)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            FechaInicio = inicio;
            FechaFin = fin;
            TiempoEstimado = tiempoestimado;
            Categoria = cat;

        }
        

        public Tareas(int ra)
        {
           racha = ra;


        }
        public override string ToString()
        {
            return $"{Titulo} ";
        }
        
        public void AgregarTiempo(TimeSpan tiempo)
        {
            TiempoTrabajado += tiempo;
        }
  
        public string ObtenerDescripcion()
        {
            return Descripcion ;


        }

    }
}
