using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Curso Completo C# 11 + .NET 8 ===");
            Console.WriteLine("Módulo 2: Variables y tipos de datos\n");

            // === 1. TIPOS PRECINTIVOS: ENTEROS ===
            // byte: 0 a 255 (1 byte)
            byte edadUsuario = 25;

            // short: -32,768 a 32,767 (2 bytes)
            short numeroCorto = 1000;

            // int: -2,147,483,648 a 2,147,483,647 (4 bytes) - más común
            int idRegistro = 12345;

            // long: -9 quintillones a 9 quintillones (8 bytes)
            // Nota: Sufijo 'L' o 'l' obligatorio para literales long
            long identificadorGrande = 9223372036854775807L;

            Console.WriteLine("--- Tipos Enteros ---");
            Console.WriteLine($"byte (edad): {edadUsuario}");
            Console.WriteLine($"short (número): {numeroCorto}");
            Console.WriteLine($"int (ID): {idRegistro}");
            Console.WriteLine($"long (grande): {identificadorGrande}");

            // === 2. TIPOS PRECINTIVOS: DECIMALS ===
            // double: punto flotante de 64 bits (8 bytes)
            double precioProducto = 19.99;
            double pi = 3.14159265358979;

            // decimal: punto flotante de 128 bits, precisión exacta (16 bytes)
            // Ideal para finanzas/bancos para evitar errores de redondeo
            decimal precioExacto = 19.99m; // Sufijo 'm' o 'M'

            Console.WriteLine("\n--- Tipos Decimales ---");
            Console.WriteLine($"double (precio): {precioProducto}");
            Console.WriteLine($"double (PI): {pi}");
            Console.WriteLine($"decimal (precio exacto): {precioExacto}");

            // === 3. TIPO TEXTO ===
            // string: secuencia de caracteres, reference type
            string nombreCompleto = "Desarrollador C#";
            string vacio = "";

            // Caracter individual: char, tipo value de 2 bytes (Unicode)
            char inicial = 'D';

            Console.WriteLine("\n--- Tipo Texto ---");
            Console.WriteLine($"nombre: {nombreCompleto}");
            Console.WriteLine($"inicial: {inicial}");
            Console.WriteLine($"longitud nombre: {nombreCompleto.Length}");

            // === 4. TIPO LÓGICO ===
            // bool: true o false, 1 byte, type value
            bool esDesarrollador = true;
            bool esPrincipiante = false;

            Console.WriteLine("\n--- Tipo Lógico ---");
            Console.WriteLine($"esDesarrollador: {esDesarrollador}");
            Console.WriteLine($"esPrincipiante: {esPrincipiante}");

            // === 5. VARIABLES CON INEFCIÓN DE TIPO ===
            // `var`: el compilador deduce el tipo en tiempo de compilación
            // Reglas: debe inicializarse al declararse, solo lectura después
            var anosExperiencia = 7;        // int
            var esTiempoCompleto = true;    // bool
            var nombreCorto = "C#";         // string

            Console.WriteLine("\n--- Variable `var` ---");
            Console.WriteLine($"var anos: {anosExperiencia} (tipo: {anosExperiencia.GetType().Name})");
            Console.WriteLine($"var esFulltime: {esTiempoCompleto} (tipo: {esTiempoCompleto.GetType().Name})");
            Console.WriteLine($"var nombre: {nombreCorto} (tipo: {nombreCorto.GetType().Name})");

            // === 6. CONSTANTES ===
            // `const`: valor fijo que no puede cambiar jamás
            // Debe inicializarse al declararse y es siempre static
            const double IVA = 0.16;
            const int DIAS_SEMANA = 7;
            const string MI_NOMBRE = "Curso C#";

            Console.WriteLine("\n--- Constantes ---");
            Console.WriteLine($"IVA: {IVA}");
            Console.WriteLine($"Días en semana: {DIAS_SEMANA}");
            Console.WriteLine($"Mi nombre: {MI_NOMBRE}");

            // Console.ReadKey() no disponible en este entorno, omitir pausa
        }
    }
}