using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Grupo2
{
    public class Celular : Producto
    {
        public string procesador { get; set; }
        public int memoriaRam { get; set; } 

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
