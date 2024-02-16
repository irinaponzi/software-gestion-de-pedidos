using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pedidos.Logueo;

namespace pedidos.Entidades
{
    internal class Usuario
    {
        string nombreUsuario;
        string passwordHash;

        // El password se ingresa en string, se llama al método de la clase
        // PasswordHash para pasar el string a hash y eso es lo que se almacena en el atributo
        public Usuario(string nombreUsuario, string password)
        {
            this.nombreUsuario = nombreUsuario;
            passwordHash = PasswordHash.obtenerHashPassword(password);
        }

        public string getNombreUsuario()
        {
            return nombreUsuario;
        }

        public string getPasswordHash()
        {
            return passwordHash;
        }

        // Método ToString para visualizar datos por consola
        public override string ToString()
        {
            return "Nombre usuario: " + nombreUsuario + ", Password: " + passwordHash;
        }
    }
}
