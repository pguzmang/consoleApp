using Humanizer;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Por favor ingrese un nombre");
var nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cargo");
var cargo = Console.ReadLine();
Console.WriteLine("Por favor ingrese su edad");
var edadStr = Console.ReadLine();
Console.WriteLine($"edadStr {edadStr} is null: " + string.IsNullOrEmpty(edadStr));
var edad = 0;
Console.WriteLine($" is null: " + string.IsNullOrEmpty(edadStr));
if (!string.IsNullOrEmpty(edadStr)) {
    edad = int.Parse(edadStr);
    Console.WriteLine($"edad {edad}");
}

Console.WriteLine($"Mi nombre es {nombre}, mi cargo es {cargo} y mi edad es {edad.ToWords(new System.Globalization.CultureInfo("en"))}");
