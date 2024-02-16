using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Entidades
{
    internal class ItemPlatoSecundario : ItemMenu
    {
        private bool porcionDoble;

        public ItemPlatoSecundario(int codigo, string nombre, string descripcion, int precio) : base(codigo, nombre, descripcion, precio)
        {

        }

        public bool getPorcionDoble()
        {
            return porcionDoble;
        }

        // La porción doble se setea cuando se realiza el pedido
        public void setPorcionDoble(bool porcionDoble)
        {
            this.porcionDoble = porcionDoble;
        }

        // Sobreescribe el método de la clase padre
        // Dependiendo de la ración doble se modifica el precio
        public override float calcularPrecioTotal()
        {
            var precioTotal = base.calcularPrecioTotal();

            if (porcionDoble)
                precioTotal = (float)Math.Floor(precioTotal * 1.5);

            return precioTotal;
        }

        // Método ToString para visualizar datos por consola
        public override string ToString()
        {
            return base.ToString() + ", Porcion doble: " + porcionDoble;
        }
    }
}
