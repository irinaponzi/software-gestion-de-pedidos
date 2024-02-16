using pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Logueo
{
    internal class SesionEmpleado
    {
        static SesionEmpleado instancia;
        Empleado empleadoLogueado;

        // La sesión del Empleado es manejada con un Singleton
        private SesionEmpleado() { }

        // Devuelve la misma instancia si ya existe. 
        public static SesionEmpleado getInstancia()
        {
            if (instancia == null)
            {
                instancia = new SesionEmpleado();
            }

            return instancia;
        }

        public Empleado getEmpleadoLogueado()
        {
            return empleadoLogueado;
        }

        // Para poder iniciar sesión tiene que haber un empleado asociado 
        // De ser así el método llama a la creación de la instancia
        public static void iniciarSesion(Empleado empleado)
        {
            if (empleado != null)
            {
                getInstancia();
                instancia.empleadoLogueado = empleado;
            }
            else
            {
                MessageBox.Show("No se puede iniciar sesión. Ya hay una sesión en curso o el empleado es nulo.");
            }
        }
    }
}
