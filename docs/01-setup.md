# Curso Completo C# 11 + .NET 8

## Módulo 1: Setup y Fundamentos

### Fecha: 2026-10-19
### Estado: Completado

#### Objetivos
- Configurar .NET 8 SDK
- Crear proyecto de consola
- Entender sintaxis básica de C#

#### Comandos ejecutados
- `dotnet new console --name CursoCSharp --framework net8.0`
- Estructura de proyecto creada

#### Nota
Proyecto base creado con la estructura estándar de .NET 8.

## Módulo 2: Variables y tipos de datos

### Fecha: 2026-10-20
### Estado: Completado

#### Objetivos
- Aprender los tipos de datos primitivos de C#
- Entender la inferencia de tipo con `var`
- Trabajar con constantes y readonly
- Diferenciar entre tipos value y reference

#### Comandos ejecutados
- `dotnet run` - Ejecutar el proyecto actual para ver los tipos de datos

#### Nota
**Program.cs** contiene el Módulo 2 completado: variables y tipos de datos. Se cubrieron tipos enteros (byte, short, int, long), tipos decimales (double, decimal), tipo texto (string, char), tipo lógico (bool), variable `var` y constantes `const`.

**Resultado al ejecutar `dotnet run`:**
```
=== Curso Completo C# 11 + .NET 8 ===
Módulo 2: Variables y tipos de datos

--- Tipos Enteros ---
byte (edad): 25
short (número): 1000
int (ID): 12345
long (grande): 9223372036854775807

--- Tipos Decimales ---
double (precio): 19.99
double (PI): 3.14159265358979
decimal (precio exacto): 19.99

--- Tipo Texto ---
nombre: Desarrollador C#
inicial: D
longitud nombre: 16

--- Tipo Lógico ---
esDesarrollador: True
esPrincipiante: False

--- Variable `var` ---
var anos: 7 (tipo: Int32)
var esFulltime: True (tipo: Boolean)
var nombre: C# (tipo: String)

--- Constantes ---
IVA: 0.16
Días en semana: 7
Mi nombre: Curso C#
```

## Módulo 3: Operadores y flujo de control

### Fecha: 2026-10-20
### Estado: Disponible en Modulo3.cs

#### Objetivos
- Dominar operadores aritméticos, de comparación y lógicos
- Estrructuras de control: if, switch, bucles (for, while)
- Expressions switch y polimorfismo simple

#### Comandos ejecutados
- `dotnet run` - Ejecuta el Módulo 2 actual

#### Nota
**Modulo3.cs** contiene el Módulo 3: Operadores y flujo de control como una clase estática `Modulo3OperadoresFlujo` con métodos demostrativos:
- `EjemploOperadoresAritmeticos()`
- `EjemploComparacionYLogicos()`
- `EjemploEstructurasControl()`
- `EjemploCompleto()`

El código del Módulo 3 incluye:
- Operadores aritméticos (+, -, *, /, %)
- Operadores de comparación (>, <, ==, !=)
- Operadores lógicos (&&, ||, !)
- Estructura if-else
- Bucles for y while
- Switch expression (C# 8+)

**Para ver el Módulo 3**, puede consultar el archivo `Modulo3.cs` o solicitar cómo integrar sus métodos en el proyecto principal.

---

Estructura actual de archivos:
- `Program.cs` → Módulo 2 (Variables y tipos de datos) ✅ Ejecutable
- `Modulo3.cs` → Módulo 3 (Operadores y flujo de control) 📋 Clase de apoyo
- `docs/01-setup.md` → Documentación del progreso
- `CursoCSharp.csproj` → Configuración del proyecto .NET 8