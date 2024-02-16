using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Tipo
{
    Carne,
    Pollo,
    Veggie
}

namespace pedidos.Entidades
{
    internal class ItemPlatoPrincipal : ItemMenu
    {
        private Tipo tipo;

        public ItemPlatoPrincipal(int codigo, string nombre, string descripcion, int precio, Tipo tipo) : base(codigo, nombre, descripcion, precio)
        {
            this.tipo = tipo;
        }

        public Tipo getTipo()
        {
            return tipo;
        }

        // El tipo se setea cuando se realiza el pedido
        public void setTipo(Tipo tipo)
        {
            this.tipo = tipo;
        }

        // Método ToString para visualizar datos por consola
        public override string ToString()
        {
            return base.ToString() + ", Tipo: " + tipo;
        }

    }
}
