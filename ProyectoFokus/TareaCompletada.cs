using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFokus
{
    public partial class TareaCompletada : Form
    {
        private int tiempoRestante = 5;
        public TareaCompletada(string nombreTarea)
        {
            InitializeComponent();
            lblmensaje.Text = $"¡Tarea \"{nombreTarea}\" completada!\n¡Bien hecho!";
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            AutoCloserTimer.Start();
        }

        private void AutoCloserTimer_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            if (tiempoRestante <= 0)
            {
                AutoCloserTimer.Stop();
                this.Close();
            }
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {

        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }
    }
    }

