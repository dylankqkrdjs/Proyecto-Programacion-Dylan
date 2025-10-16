using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProyectoFokus
{

    public partial class Fokus : Form
    {
        public Fokus()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.Nombre = txtNombre.Text.Trim();
                user.Apellido = txtApellido.Text.Trim();
                user.Gmail = txtCorreo.Text.Trim();
                user.Password = txtContraseña.Text; // se hashea en el controlador

                Controlador control = new Controlador();

                control.generarSHA1(user.Password);
                string rta = control.ctrlRegistroUsuarios(user);

                MessageBox.Show(rta, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rta == "Registro exitoso")
                {
                    // podés limpiar los campos
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCorreo.Clear();
                    txtContraseña.Clear();

                    // o si querés cerrar este form e ir directo al login
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en btnRegistrar: " + ex.Message);
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instrucciones\n ¿En serio, es necesario que haya instrucciones sobre esto ? \n Coloque la informacion solicitada. ");
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
