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
    public partial class FokusCrearTarea : Form
    {
         public string Titulo { get; private set; }
    public string Descripcion { get; private set; }
    public DateTime FechaInicial { get; private set; }
    public DateTime FechaFinal { get; private set; }
        
        public string Categoria { get; private set; }

    public int TiempoEstimado { get; private set; }

  
        public FokusCrearTarea()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void CrearTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTitulo.Text) || string.IsNullOrWhiteSpace(TxtDesc.Text) || string.IsNullOrEmpty(Testimado1.Text) || string.IsNullOrEmpty(radioButton2.Text) || string.IsNullOrEmpty(radioButton3.Text) || string.IsNullOrEmpty(radioButton4.Text) ||string.IsNullOrWhiteSpace(CategoriaTarea.Text))
            {   
                
                
                    MessageBox.Show("Por favor completa todos los campos.");
                    return;
                
                
       
            }

            
            Titulo = TxtTitulo.Text;
            Descripcion = TxtDesc.Text;
            FechaInicial = FechaInicio.Value;
         
            Categoria = CategoriaTarea.Text;

            if (Testimado1.Checked == false || radioButton2.Checked == false || radioButton3.Checked == false || radioButton4.Checked == false)
            {
                TiempoEstimado = 1;

            }
            if (Testimado1.Checked)
                TiempoEstimado = 5;
            else if (radioButton2.Checked)
                TiempoEstimado = 15;
            else if (radioButton3.Checked)
                TiempoEstimado = 30;
            else if (radioButton4.Checked)
                TiempoEstimado = 60;
            
            
                this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Testimado1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CategoriaTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FechaFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaInicio_ValueChanged(object sender, EventArgs e)
        {
            FechaInicio.MinDate = DateTime.Now;
        }
    }
}
