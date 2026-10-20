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
            byte edadUsuario = 25;
            short numeroCorto = 1000;
            int idRegistro = 12345;
            long identificadorGrande = 9223372036854775807L;

            Console.WriteLine("--- Tipos Enteros ---");
            Console.WriteLine($"byte (edad): {edadUsuario}");
            Console.WriteLine($"short (número): {numeroCorto}");
            Console.WriteLine($"int (ID): {idRegistro}");
            Console.WriteLine($"long (grande): {identificadorGrande}");

            // === 2. TIPOS PRECINTIVOS: DECIMALS ===
            double precioProducto = 19.99;
            double pi = 3.14159265358979;
            decimal precioExacto = 19.99m;

            Console.WriteLine("\n--- Tipos Decimales ---");
            Console.WriteLine($"double (precio): {precioProducto}");
            Console.WriteLine($"double (PI): {pi}");
            Console.WriteLine($"decimal (precio exacto): {precioExacto}");

            // === 3. TIPO TEXTO ===
            string nombreCompleto = "Desarrollador C#";
            string vacio = "";
            char inicial = 'D';

            Console.WriteLine("\n--- Tipo Texto ---");
            Console.WriteLine($"nombre: {nombreCompleto}");
            Console.WriteLine($"inicial: {inicial}");
            Console.WriteLine($"longitud nombre: {nombreCompleto.Length}");

            // === 4. TIPO LÓGICO ===
            bool esDesarrollador = true;
            bool esPrincipiante = false;

            Console.WriteLine("\n--- Tipo Lógico ---");
            Console.WriteLine($"esDesarrollador: {esDesarrollador}");
            Console.WriteLine($"esPrincipiante: {esPrincipiante}");

            // === 5. VARIABLES CON INEFCIÓN DE TIPO ===
            var anosExperiencia = 7;
            var esTiempoCompleto = true;
            var nombreCorto = "C#";

            Console.WriteLine("\n--- Variable `var` ---");
            Console.WriteLine($"var anos: {anosExperiencia} (tipo: {anosExperiencia.GetType().Name})");
            Console.WriteLine($"var esFulltime: {esTiempoCompleto} (tipo: {esTiempoCompleto.GetType().Name})");
            Console.WriteLine($"var nombre: {nombreCorto} (tipo: {nombreCorto.GetType().Name})");

            // === 6. CONSTANTES ===
            const double IVA = 0.16;
            const int DIAS_SEMANA = 7;
            const string MI_NOMBRE = "Curso C#";

            Console.WriteLine("\n--- Constantes ---");
            Console.WriteLine($"IVA: {IVA}");
            Console.WriteLine($"Días en semana: {DIAS_SEMANA}");
            Console.WriteLine($"Mi nombre: {MI_NOMBRE}");
        }
    }
}