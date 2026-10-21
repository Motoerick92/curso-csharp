using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Curso Completo C# 11 + .NET 8 ===");
            Console.WriteLine("Menú de Módulos Disponibles");
            Console.WriteLine("1. Módulo 1: Setup y Fundamentos");
            Console.WriteLine("2. Módulo 2: Variables y tipos de datos");
            Console.WriteLine("3. Módulo 3: Operadores y flujo de control");
            Console.WriteLine("0. Salir");

            Console.Write("\nSeleccione un módulo: ");
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Modulo1Setup.Ejecutar();
                    break;
                case "2":
                    Modulo2Variables.Ejecutar();
                    break;
                case "3":
                    Modulo3OperadoresFlujo.EjemploCompleto();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}