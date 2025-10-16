using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

namespace ProyectoFokus
{
    internal class Controlador
    {
        public string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
        public string ctrlLogin(Usuario user)
        {

            ModeloUsuarios conexion = new ModeloUsuarios();

            bool valido = conexion.ValidarLogin(user);
            if (valido)
                return "OK";
            else
                return "Usuario o contraseña incorrectos";
        }
        public string ctrlRegistroUsuarios(Usuario user)
        {
            ModeloUsuarios modelo = new ModeloUsuarios();
            string rta = "";

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(user.Nombre) || string.IsNullOrEmpty(user.Password))
            {
                rta = "Datos incompletos";
            }
            else if (modelo.existeUsuario(user)) // Validación de usuario ya existente
            {
                rta = $"¡El nombre de usuario {user.Nombre} no está disponible!";
            }
            else
            {
                // Encripto la contraseña antes de guardar
                user.Password = generarSHA1(user.Password);

                if (modelo.registrarUsuario(user))
                    rta = "¡Alta exitosa!";
                else
                    rta = "¡Error inesperado!";
            }

            return rta;
        }
        public string ctrlRegistroUsuarios2(string user)
        {
           
                // Encripto la contraseña antes de guardar
                user= generarSHA1(user);

               
                return user;
        }
    }

    }



