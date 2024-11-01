﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Grupo2
{
    public class Computadora : Producto
    {
        private string procesador;
        private int memoriaRam;
        private bool lectorDisco;

        public Computadora(int productoId, string nombre, double precio, int stock, string procesador, int memoriaRam, bool lectorDisco) : base(productoId, nombre, precio, stock)
        {
            this.procesador = procesador;
            this.memoriaRam = memoriaRam;
            this.lectorDisco = lectorDisco;
        }

        public override double CalcularTotal()
        {
            throw new NotImplementedException();
        }
    }
}
