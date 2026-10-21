using System;

namespace CursoCSharp
{
    // Clase para el Módulo 1: Setup y Fundamentos
    // Contiene la lógica básica del curso
    public static class Modulo1Setup
    {
        // Ejecuta el ejemplo del Módulo 1
        public static void Ejecutar()
        {
            Console.WriteLine("=== Curso Completo C# 11 + .NET 8 ===");
            Console.WriteLine("Módulo 1: Setup y fundamentos");
            Console.WriteLine("Hola, mundo desde C#!");

            // Ejemplo básico de variable
            string nombre = "Desarrollador C#";
            int anosDeExperiencia = 5;

            Console.WriteLine($"Bienvenido, {nombre} con {anosDeExperiencia} años de experiencia.");
        }
    }
}