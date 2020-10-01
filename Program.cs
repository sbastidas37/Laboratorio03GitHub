using System;

namespace Laboratorio03GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /* Solicito el nombre del usuario */
            Console.WriteLine("\nWhat is your name? ");
            /*Capturo los datos (nombre y fecha) en unas variables*/
            var name = Console.ReadLine();
            var date = DateTime.Now;
            /*Imprimir los resultados por pantalla*/
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);

        }
    }
}
