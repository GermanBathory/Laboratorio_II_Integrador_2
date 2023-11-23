using Entidades;
namespace ConsolaDePruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Jorge", "Lopez", 25052666);
            Viaje viaje = new Viaje(EEmpresa.Chevallier, ECiudad.Santa_Fe, ECiudad.Mendoza, DateTime.Now, DateTime.Now);
            Console.WriteLine($"{cliente.MostrarInformacion()}");
            Console.WriteLine($"{viaje.ImprimirPasaje()}");
        }
    }
}