using System;

namespace CursoCSharp
{
    // Clase para demostraciones del Módulo 3 (Operadores y flujo de control)
    // No tiene Main - se puede ejecutar llamando a sus métodos desde otro programa
    public static class Modulo3OperadoresFlujo
    {
        // Ejemplo de operadores aritméticos
        public static void EjemploOperadoresAritmeticos()
        {
            Console.WriteLine("=== Ejemplo: Operadores Aritméticos ===");
            int num1 = 10;
            int num2 = 3;

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} × {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} ÷ {num2} = {num1 / num2} (división entera)");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2} (residuo)");
        }

        // Ejemplo de operadores de comparación y lógicos
        public static void EjemploComparacionYLogicos()
        {
            Console.WriteLine("\n=== Ejemplo: Comparación y Lógicos ===");
            bool mayor = 10 > 3;
            bool menor = 10 < 3;
            bool iguales = 10 == 3;
            bool diferentes = 10 != 3;

            Console.WriteLine($"10 > 3: {mayor}");
            Console.WriteLine($"10 < 3: {menor}");
            Console.WriteLine($"10 == 3: {iguales}");
            Console.WriteLine($"10 != 3: {diferentes}");

            bool condA = true;
            bool condB = false;
            Console.WriteLine($"condA && condB: {condA && condB}");
            Console.WriteLine($"condA || condB: {condA || condB}");
            Console.WriteLine($"!condA: {!condA}");
        }

        // Ejemplo de estructuras de control
        public static void EjemploEstructurasControl()
        {
            Console.WriteLine("\n=== Ejemplo: Estructuras de Control ===");

            // Bucle for
            Console.WriteLine("Bucle for (cuenta regresiva):");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine($"  i = {i}");
            }

            // Bucle while
            Console.WriteLine("Bucle while:");
            int contador = 0;
            while (contador < 3)
            {
                Console.WriteLine($"  contador = {contador}");
                contador++;
            }

            // Switch expression
            Console.WriteLine("Switch Expression:");
            int dia = 3;
            string nombreDia = dia switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Día inválido"
            };
            Console.WriteLine($"Día {dia}: {nombreDia}");
        }

        // Ejemplo práctico completado
        public static void EjemploCompleto()
        {
            Console.WriteLine("=== Ejemplo Complejo Módulo 3 ===");

            // Operaciones aritméticas
            int a = 20, b = 7;
            Console.WriteLine($"Suma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");
            Console.WriteLine($"División entera: {a / b}");
            Console.WriteLine($"Residuo: {a % b}");

            // Estructuras de control
            if (a > b)
                Console.WriteLine($"{a} es mayor que {b}");
            else if (a < b)
                Console.WriteLine($"{a} es menor que {b}");
            else
                Console.WriteLine($"{a} es igual que {b}");

            // Bucle for
            Console.WriteLine("Cuenta del 1 al 5:");
            for (int i = 1; i <= 5; i++)
                Console.WriteLine($"  {i}");

            // Bucle while sumando 1 al 5
            int suma = 0;
            int j = 1;
            while (j <= 5)
            {
                suma += j;
                j++;
            }
            Console.WriteLine($"Suma de 1 a 5: {suma}");

            // Switch
            int diaNum = 3;
            Console.WriteLine($"Día {diaNum}: {diaNum switch { 1 => "Lunes", 2 => "Martes", 3 => "Miércoles", _ => "Otro" }}");
        }
    }
}