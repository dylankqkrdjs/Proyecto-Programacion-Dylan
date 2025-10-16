using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFokus
{
    internal class Usuario
    {
        private int id;
        private string password;
        private string gmail;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get; set; }

    }
}
