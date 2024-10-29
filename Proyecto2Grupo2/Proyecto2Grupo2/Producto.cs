using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Grupo2
{
    public abstract class Producto : IPagable
    {
        public int productoId { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }

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
