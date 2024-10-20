using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Grupo2
{
    public class Auricular : Producto
    {
        private double potenciaWatts;

        public Auricular(int productoId, string nombre, double precio, int stock, double pot) : base(productoId, nombre, precio, stock)
        {
            this.potenciaWatts = pot;
        }

        public override double CalcularTotal()
        {
            throw new NotImplementedException();
        }
    }
}
