using pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Logueo
{
    internal class LogIn
    {
        List<Empleado> empleados;

        // Desde el constructor se recupera la lista de Empleados almacenados 
        public LogIn()
        {
            empleados = Resources.Datos.obtenerEmpleados();
        }

        // Valida si los datos ingresados en el log in coinciden con el usuario de algún empleado
        public bool validarUsuario(string nombreEntrada, string passEntrada)
        {            
            // Se busca en la lista de empleados el nombre de usuario que coincida, ya que este dato sería único en la "BD"
            var empleado = empleados.Find(e => e.getUsuario().getNombreUsuario().Equals(nombreEntrada));

            if (empleado != null)
            {
                string nombreUsuario = empleado.getUsuario().getNombreUsuario();
                var passSalidaUsuario = empleado.getUsuario().getPasswordHash();

                // Se realiza la verificación de nombre y password. Para verificar la password se llama al método de la clase PasswordHash
                bool verificarNombre = nombreUsuario.Equals(nombreEntrada);
                bool verificarPassword = PasswordHash.compararHash(passEntrada, passSalidaUsuario);

                if (verificarNombre && verificarPassword)
                {
                    // Si la verificación es true, se inicia la sesión del empleado llamando al método de la clase SesiónEmpleado 
                    SesionEmpleado.iniciarSesion(empleado);
                    return true;
                }
                else                 
                    return false;
            }
            else
               // Aqui solo verifica usuario, pero se muestra así para no dar información tan específica
               return false;
        }
    }
}
