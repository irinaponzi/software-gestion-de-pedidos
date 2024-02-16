using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Entidades
{
    internal class Empleado
    {
        int id;
        string nombre;
        string apellido; 
        Usuario usuario;

        public Empleado() { }
        
        public Empleado(int id, string nombre, string apellido, string nombreUsuario, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            usuario = new Usuario(nombreUsuario, password);
        }

        public int getId()
        {
            return id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellido()
        {
            return apellido;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void getApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public Usuario getUsuario()
        {
            return usuario;
        }

        // Método ToString para visualizar datos por consola
        public override string ToString()
        {
            return "Id: " + id + " - Nombre: " + nombre + ", Apellido: " + apellido;
        }
    }
}
