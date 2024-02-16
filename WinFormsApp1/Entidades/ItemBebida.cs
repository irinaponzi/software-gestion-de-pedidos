using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Tamanio
{
    Normal,
    Mediano,
    Grande
}

namespace pedidos.Entidades
{
    internal class ItemBebida : ItemMenu
    {
        private Tamanio tamanio;

        public ItemBebida(int codigo, string nombre, string descripcion, int precio) : base(codigo, nombre, descripcion, precio)
        {

        }

        public Tamanio getTamanio()
        {
            return tamanio;
        }

        // El tamaño se setea cuando se realiza el pedido
        public void setTamanio(Tamanio tamanio)
        {
            this.tamanio = tamanio;
        }

        // Sobreescribe el método de la clase padre
        // Dependiendo del tamaño de la bebida se modifica el precio
        public override float calcularPrecioTotal()
        {
            var precioTotal = base.calcularPrecioTotal();

            if (tamanio == Tamanio.Mediano)
                precioTotal = (float)Math.Floor(precioTotal * 1.3);

            else if (tamanio == Tamanio.Grande)
                precioTotal = (float)Math.Floor(precioTotal * 1.5);

            return precioTotal;
        }

        // Método ToString para visualizar datos por consola
        public override string ToString()
        {
            return base.ToString() + ", Tamaño: " + tamanio;
        }
    }
}
