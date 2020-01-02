using Service;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotecaService biblio = new BibliotecaService();
            var l = biblio.getCartiSolicitate();
            Console.WriteLine(l.Count);
            Console.WriteLine();
        }
    }
}
