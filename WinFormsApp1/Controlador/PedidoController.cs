using pedidos.Entidades;
using pedidos.Resources;
using pedidos.Logueo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Controlador
{
    internal class PedidoController
    {
        Pedido pedido;
        SesionEmpleado sesion = SesionEmpleado.getInstancia();

        private static PedidoController instancia;

        // Singleton para el PedidoController 
        public static PedidoController Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new PedidoController();
                }
                return instancia;
            }
        }

        // El constructor llama al método que inicia un nuevo pedido
        public PedidoController()
        {
            iniciarNuevoPedido();
        }

        public Pedido getPedido()
        {
            return pedido;
        }

        // Se instancia un pedido y se le asocia un empleado
        public void iniciarNuevoPedido()
        {
            pedido = new Pedido();
            pedido.setEmpleado(sesion.getEmpleadoLogueado());
        }

        // Al finalizar el pedido se imprime el mismo llamando al 
        // método de la clase Imprimir
        public void finalizarPedido()
        {
            MessageBox.Show("Pedido finalizado");
            Imprimir.imprimirPedido(pedido);
            
            // Se inicia un nuevo pedido
            iniciarNuevoPedido();
        }

        // Agrega un nuevo item al detalle del pedido
        public void agregarItemMenu(ItemMenu nuevoItemMenu, int cantidad)
        {
            pedido.getDetalle().agregarItem(nuevoItemMenu, cantidad);
        }
    }
}
