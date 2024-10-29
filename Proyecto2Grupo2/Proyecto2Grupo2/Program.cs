namespace Proyecto2Grupo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Somos electrónicaG2");

            var contexto = new Contexto();
            var cliente1 = new Cliente()
            {
                nombre = "Pepito",
                apellido = "Perez",
                domicilio = "Av. Rivadavia 3000"
            };
            var cliente2 = new Cliente()
            {
                nombre = "Maria",
                apellido = "Sanchez",
                domicilio = "Av. La Plata 203"
            };
            var cliente3 = new Cliente()
            {
                nombre = "Carlos",
                apellido = "Calvo",
                domicilio = "Echeandia 6024"
            };

            contexto.Clientes.Add(cliente1);           
            contexto.SaveChanges();
            Console.WriteLine("Cliente agregado");
            contexto.Clientes.Add(cliente2);
            contexto.SaveChanges();
            Console.WriteLine("Cliente agregado");
            contexto.Clientes.Add(cliente3);
            contexto.SaveChanges();
            Console.WriteLine("Cliente agregado");

            Console.ReadKey();
        }
    }
}
