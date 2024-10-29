using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Proyecto2Grupo2
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }

        public Cliente() { }
        public Cliente(int clienteId, string nombre, string apellido, string domicilio)
        {
            this.clienteId = clienteId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
        }
        
    }
}
