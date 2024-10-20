using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Grupo2
{
    public abstract class Producto : IPagable
    {
        private int productoId;
        private string nombre;
        private double precio;
        private int stock;

        public Producto(int productoId, string nombre, double precio, int stock)
        {
            this.productoId = productoId;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        public abstract double CalcularTotal();
    }
}
