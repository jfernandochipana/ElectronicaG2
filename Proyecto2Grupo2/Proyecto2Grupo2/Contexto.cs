using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Grupo2
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FERNANDO-PC\SQLEXPRESS;
                                        Database=ElectronicaG2.DB;
                                        Trusted_Connection=True;
                                        TrustServerCertificate=True;");
        }
    }
}
