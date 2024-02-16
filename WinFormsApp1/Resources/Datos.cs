using pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidos.Resources
{
    internal class Datos
    {
        
        // Obtiene los datos de los empleados simulando una BD
        public static List<Empleado> obtenerEmpleados()
        {
            var lista = new List<Empleado>();

            lista.Add(new Empleado(777, "Pablo", "Avellaneda", "PAvellaneda", "Prueba777"));
            lista.Add(new Empleado(100, "Florencia", "Perea", "FPerea", "Prueba123"));
            lista.Add(new Empleado(110, "Gonzalo", "Gimenez", "GGimenez", "Prueba456"));
            lista.Add(new Empleado(120, "Irina", "Ponzi", "IPonzi", "Prueba789"));

            return lista;

        }

        // Obtiene los datos de los items del menú simulando una BD
        public static List<ItemMenu> obtenerItemMenu()
        {
            var lista = new List<ItemMenu>()
            {
                new ItemPlatoPrincipal(505, "Hamburguesa de carne", "Lomito, lechuga, tomate y mayonesa", 2800, Tipo.Carne),
                new ItemPlatoPrincipal(506, "Hamburguesa de pollo", "Pechuga, tomate, lechugaa y mayonesa", 2500, Tipo.Pollo),
                new ItemPlatoPrincipal(507, "Hamburguesa veggie", "NotCo, lechuga, tomate y mayonesa vegana", 2900, Tipo.Veggie),

                new ItemPlatoSecundario(435, "Papas Fritas", "Rústicas", 1800),
                new ItemPlatoSecundario(436, "Aros de cebolla", "Clásicos aros de cebolla", 2000),
                new ItemPlatoSecundario(437, "Ensalada", "Tomate, zanahoria y rúcula", 3000),

                new ItemBebida(315, "Agua", "Agua sin gas", 1800),
                new ItemBebida(316, "Gaseosa", "Coca Cola", 2100),
                new ItemBebida(317, "Cerveza", "Pinta IPA", 2800)
            };

            return lista;

        }
    }
}
