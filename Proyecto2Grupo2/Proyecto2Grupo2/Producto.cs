using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Grupo2
{
    public abstract class Producto : IPagable
    {
        public abstract double CalcularTotal();
    }
}
