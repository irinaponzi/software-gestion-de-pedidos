using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Entidades
{
    internal class DetallePedido
    {
        List<ItemMenu> detalle;

        public DetallePedido()
        {
            detalle = new List<ItemMenu>();
        }

        public List<ItemMenu> getDetallePedido()
        {
            return detalle;
        }

        // Agrega un item al detalle
        public void agregarItem(ItemMenu itemMenu, int cantidad)
        {
            itemMenu.setCantidad(cantidad);
            detalle.Add(itemMenu);
        }


        // Calcula el monto total del detalle
        public float calcularMontoTotal()
        {
            float precio = 0;

            foreach (var item in detalle)
            {
                precio += item.calcularPrecioTotal();
            }

            return precio;
        }

        // Método ToString para visualizar datos por consola
        public override string ToString()
        {
            string texto = "Detalle Pedido:\n";

            foreach (var item in detalle)
            {
                texto += item.ToString() + ". Precio Total Item: $" + item.calcularPrecioTotal() + "\n";
            }

            return texto;
        }
    }
}
