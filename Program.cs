using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Curso Completo C# 11 + .NET 8 ===");
            Console.WriteLine("Módulo 1: Setup y fundamentos");
            Console.WriteLine("Hola, mundo desde C#!");
            
            // Ejemplo básico de variable
            string nombre = "Desarrollador C#";
            int añosDeExperiencia = 5;
            
            Console.WriteLine($"Bienvenido, {nombre} con {añosDeExperiencia} años de experiencia.");
            
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}