using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Entidades
{
    internal class ItemMenu
    {
        int codigo;
        string nombre;
        string descripcion;
        int cantidad;
        int precio;

        public ItemMenu(int codigo, string nombre, string descripcion, int precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getDescripcíon()
        {
            return descripcion;
        }
        public int getCantidad()
        {
            return cantidad;
        }
        public int getPrecio()
        {
            return precio;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        // La cantidad se setea cuando se realiza el pedido
        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public void setPrecio(int precio)
        {
            this.precio = precio;
        }

        // Calcula el monto total del item según precio y cantidad
        public virtual float calcularPrecioTotal()
        {
            var precioTotal = precio * cantidad;
            return precioTotal;
        }

        // Método ToString para visualizar datos por consola
        public override string ToString()
        {
            return "Código: " + codigo + ", Nombre: " + nombre + ", Cantidad: " + cantidad + ", Precio Unitario: $" + precio;
        }
    }
}
