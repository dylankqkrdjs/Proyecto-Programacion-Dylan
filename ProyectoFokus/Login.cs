using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProyectoFokus
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ContraUsu.Text) || string.IsNullOrWhiteSpace(GmailUsu.Text))
            {
                MessageBox.Show("Por favor complete los campos");
                return;
            }

            try
            {
                Usuario user = new Usuario();
                user.Gmail = GmailUsu.Text;
                user.Password = ContraUsu.Text; // texto plano, se encripta más adelante

                Controlador control = new Controlador();
                string rta = control.ctrlLogin(user);

                if (rta == "OK")
                {
                    FokusPrincipal menu = new FokusPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(rta, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EdadUsu_TextChanged(object sender, EventArgs e)
        {
            ContraUsu.UseSystemPasswordChar = true;
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            Form Form3 = new Fokus();
            Form3.ShowDialog();

        }

        private void NombreUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerContra_CheckedChanged(object sender, EventArgs e)
        {
            if (VerContra.Checked)
            {
                ContraUsu.UseSystemPasswordChar = false;
            }
            else
            {
                ContraUsu.UseSystemPasswordChar = true;
            }

        }
    }
}
