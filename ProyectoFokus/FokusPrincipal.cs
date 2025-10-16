using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Mysqlx.Crud;

namespace ProyectoFokus
{
    public partial class FokusPrincipal : Form
    {
        private List<Tareas> listaTareas = new List<Tareas>();
        private Timer timer;
        private int segundosTrabajados = 0;
        private Tareas TiempoTrabajado = null;
        private Tareas tareaActiva; // la que se cronometra actualmente
        private Tareas tareaCronometrada = null;
        private bool EstadoTarea = true;
        

        public static int _año, _mes;

    
        private void Form4_Load(object sender, EventArgs e)
        {
            // Datos de ejemplo (podés traerlos desde la BD más adelante)
            

            
           
        }
        
        public FokusPrincipal()
        {   
          
            
            InitializeComponent(); // ← Esto inicializa los controles visuales
        }
        private void CompletarTarea(Tareas tareas)
        {
            tareas.TareaCompletada = true;
            tareas.fecha = DateTime.Now;
            listaTareas.Add(tareas);
            Tareas.ActualizarRacha(DateTime.Now);
            lblRacha.Text = $"racha:{Tareas.Racha}";
          
                
        }
   
        
        private void AgregarTareaVisual(string titulo, string descripcion, DateTime inicio, DateTime fin, int tiempoEstimado,string categoria)
        {
            EstadoTarea = true;

            // Crear objeto de tarea y agregarlo a la lista
            Tareas nuevaTarea = new Tareas(titulo, descripcion, inicio, fin,tiempoEstimado);
            listaTareas.Add(nuevaTarea);


            // Crear panel visual para la tarea
            Panel tareaPanel = new Panel();
            tareaPanel.Size = new Size(320, 160);
            tareaPanel.BorderStyle = BorderStyle.FixedSingle;
            tareaPanel.BackColor = Color.LightGray;
            tareaPanel.Margin = new Padding(10);

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = $"Título: {titulo}";
            lblTitulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.AutoSize = true;
            

            // Descripción
            Label lblDescripcion = new Label();
            lblDescripcion.Text = $"Descripción: {descripcion}";
            lblDescripcion.Font = new Font("Segoe UI", 9);
            lblDescripcion.Location = new Point(10, 35);
            lblDescripcion.AutoSize = true;

            // Fechas
            Label lblFechas = new Label();
            lblFechas.Text = $"Inicio: {inicio.ToShortDateString()}";
            lblFechas.Font = new Font("Segoe UI", 8, FontStyle.Italic);
            lblFechas.Location = new Point(10, 60);
            lblFechas.AutoSize = true;

            // Tiempo estimado
         
           
                Label lblTiempoEstimado = new Label();

             
                
                lblTiempoEstimado.Text = $"Tiempo estimado: {tiempoEstimado} minutos";
                lblTiempoEstimado.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblTiempoEstimado.Location = new Point(10, 85);
                lblTiempoEstimado.AutoSize = true;
       

            

            Label lblCategoria = new Label();
            lblCategoria.Text = $"Categoría: {categoria}";
            lblCategoria.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblCategoria.Location = new Point(10, 110); // Ajustamos la posición
            lblCategoria.AutoSize = true;

            // Botón seleccionar
            Button btnSeleccionar = new Button();
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.Size = new Size(100, 30);
            btnSeleccionar.Location = new Point(10, 125);
            btnSeleccionar.BackColor = Color.LightGray;
            btnSeleccionar.Click += (s, e) =>
            {
                tareaActiva = nuevaTarea;
                MessageBox.Show($"Tarea \"{titulo}\" seleccionada para cronometrar.");
            };
            Button Cerrar = new Button();
            Cerrar.Text = "X";
            Cerrar.Size = new Size(100, 30);
            Cerrar.Location = new Point(120, 125);
            Cerrar.BackColor = Color.LightGray;
            Cerrar.Click += (s, e) =>
            {
               
                tareaPanel.Hide();
                EstadoTarea = false;
               
            };
            // Agregar controles al panel
            tareaPanel.Controls.Add(Cerrar);
            tareaPanel.Controls.Add(lblTitulo);
            tareaPanel.Controls.Add(lblDescripcion);
            tareaPanel.Controls.Add(lblFechas);
            tareaPanel.Controls.Add(lblTiempoEstimado);

            tareaPanel.Controls.Add(lblCategoria);
            tareaPanel.Controls.Add(btnSeleccionar);

            // Agregar panel al contenedor de tareas (asegúrate de tener un FlowLayoutPanel)
            PanelTareas.Controls.Add(tareaPanel);
        }

      
        private void Encuesta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

  
            
            string descripcion = "";
            string titulo = "";
            int tiempoestimado = 1;
            DateTime inicio = DateTime.Today;
            DateTime fin = inicio.AddDays(7); // Duración predeterminada

            if (rdbEjercicio.Checked)
            {
                Tareas nueva = new Tareas("Pequeña rutina de ejercicio", "Hacer plancha 1 minuto por 4 rondas", inicio, fin,tiempoestimado,"Ejercicio");
                listaTareas.Add(nueva);
                AgregarTareaVisual(nueva.Titulo, nueva.Descripcion, nueva.FechaInicio, nueva.FechaFin,nueva.TiempoEstimado, nueva.Categoria);
            }
            else if (rdbAprender.Checked)
            {
                AgregarTareaVisual("Aprender algo nuevo", "Ponerse a ver cursos gratuitos o repasar la carpeta", inicio, fin,tiempoestimado,"Estudio");
            }
            else if (rdbProductividad.Checked)
            {
                AgregarTareaVisual("Productividad", "Organizar horarios, hacer itinerario, dedicarle tiempo a cosas importantes y dejar las distracciones", inicio, fin, tiempoestimado,"Productividad");
            }
            else
            {
                MessageBox.Show("Por favor selecciona una opción.");
                return;
            }

            btnFinalizar.Visible = false;
            Encuesta.Visible = false;
            rdbAprender.Visible = false;
            rdbEjercicio.Visible = false;
            rdbProductividad.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            btnIniciarPausar.Visible = true;
            lblCronometro.Visible = true;
            btnAgregarTarea.Visible = true;
            PanelTareas.Visible = true;
            
        }

        private void rdbEjercicio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAprender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            FokusCrearTarea form5 = new FokusCrearTarea();
            if (form5.ShowDialog() == DialogResult.OK)
            {
                Tareas nueva = new Tareas(form5.Titulo, form5.Descripcion, form5.FechaInicial, form5.FechaFinal, form5.TiempoEstimado,form5.Categoria);
                listaTareas.Add(nueva);

               
                AgregarTareaVisual(nueva.Titulo, nueva.Descripcion, nueva.FechaInicio, nueva.FechaFin, nueva.TiempoEstimado, nueva.Categoria);
                tareaActiva = nueva;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TareaTimer_Tick(object sender, EventArgs e)
        {
            

            segundosTrabajados++;
            lblCronometro.Text = $"En progreso: {TimeSpan.FromSeconds(segundosTrabajados):mm\\:ss}";

          
            if (tareaActiva.TareaCompletada == true)
            {
               

                
               CompletarTarea(tareaActiva);


                    


                segundosTrabajados = 0;

                TareaTimer.Stop();






                return;

            }
        
            else

                        if (tareaActiva != null && tareaActiva.TiempoEstimado > 0)
                {
                int tiempoEstimadoSegundos = tareaActiva.TiempoEstimado * 60;


                if (segundosTrabajados >= tiempoEstimadoSegundos)
                {
                    TareaTimer.Stop();

                    TareaCompletada ventanaCompletada = new TareaCompletada(tareaActiva.Titulo);
                    ventanaCompletada.Show(); // NO ShowDialog, así no bloquea



                    tareaActiva.TareaCompletada = true;

                    segundosTrabajados = 0;
                    lblCronometro.Text = "00:00";
                }
            }
        }

        private void btnIniciarPausar_Click(object sender, EventArgs e)
        {
           
            if (tareaActiva == null)
            {
                MessageBox.Show("Selecciona una tarea para cronometrar.");
                return;
            }

            // Crear el timer si aún no existe
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += TareaTimer_Tick;
            }

            // Si es una nueva tarea distinta a la cronometrada
            if (tareaCronometrada != null && tareaActiva != tareaCronometrada)
            {
                // Guardar el tiempo en la tarea anterior
                tareaCronometrada.AgregarTiempo(TimeSpan.FromSeconds(segundosTrabajados));
       
                // Resetear y detener
                segundosTrabajados = 0;
                lblCronometro.Text = "00:00";
                timer.Stop();
                btnIniciarPausar.Text = "Iniciar";

                // Cambiar la tarea cronometrada
                tareaCronometrada = tareaActiva;
                return; // Pedimos que presione de nuevo para iniciar
            }

            // Si aún no hay tarea cronometrada
            if (tareaCronometrada == null)
            {
                tareaCronometrada = tareaActiva;
            }

            // Iniciar o pausar
            if (!timer.Enabled)
            {
                timer.Start();
                btnIniciarPausar.Text = "Pausar";
            }
            else
            {
                timer.Stop();
                tareaCronometrada.AgregarTiempo(TimeSpan.FromSeconds(segundosTrabajados));
                lblCronometro.Text = $"Tiempo trabajado: {tareaCronometrada.TiempoTrabajado:mm\\:ss}";
                segundosTrabajados = 0;
                btnIniciarPausar.Text = "Iniciar";
            }
            if ( EstadoTarea == false)
            {
                timer.Stop();
                lblCronometro.Text =$"tarea no encontrada";


            }
        }

       


        
        private void lblCronometro_Click(object sender, EventArgs e)
        {

        }

        private void ChartProductividad_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TiempoActual_Tick(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTareas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRacha_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_2(object sender, EventArgs e)
        {

        }
    }
}
