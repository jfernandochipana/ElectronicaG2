using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Grupo2
{
    public class Celular : Producto
    {
        private string procesador;
        private int memoriaRam;

        public Celular(int productoId, string nombre, double precio, int stock, string procesador, int memoriaRam) : base(productoId, nombre, precio, stock)
        {
            this.procesador = procesador;
            this.memoriaRam = memoriaRam;
        }

        public override double CalcularTotal()
        {
            throw new NotImplementedException();
        }
    }
}
