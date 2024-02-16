using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Entidades
{
    internal class Pedido
    {
        static int contNumPedido = 10000000;
        int numPedido;
        DateTime fecha;
        Empleado empleado;
        DetallePedido detallePedido;
                
        public Pedido()
        {
            numPedido = contNumPedido++;
            fecha = DateTime.Now;
            empleado = new Empleado();
            detallePedido = new DetallePedido();
        }

        public int getNumPedido()
        {
            return numPedido;
        }
        public DateTime getFecha()
        {
            return fecha;
        }
        public Empleado getEmpleado()
        {
            return empleado;
        }
        public DetallePedido getDetalle()
        {
            return detallePedido;
        }

        // El empleado se setea cuando se inicializa un pedido, según el empleado logueado
        public void setEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }

        // Obtiene el monto total del detalle
        public float obtenerPagoTotal()
        {
            float pagoTotal = detallePedido.calcularMontoTotal();
            return pagoTotal;
        }

        // Método ToString para visualizar datos por consola
        public override string ToString()
        {
            string texto = "Número Pedido: " + numPedido + "\nFecha: " + fecha + "\nEmpleado: " + empleado + "\n" + detallePedido + "\nPago Total: " + obtenerPagoTotal() + "\n";
            return texto;
        }
    }
}
