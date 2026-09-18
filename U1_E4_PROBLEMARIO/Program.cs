using System;

Console.WriteLine("EJERCICIO 4");
Console.WriteLine("MEDICIONES DE CORRIENTE DE UN ACTUADOR ELÉCTRICO (8 MEDICIONES)");
Console.WriteLine();

double suma = 0;
int normales = 0;
int sobrecorrientes = 0;

for (int i = 1; i <= 8; i++)
{
    Console.Write($"Ingrese la corriente {i} (A): ");
    double corriente = Convert.ToDouble(Console.ReadLine());
    suma = suma + corriente;

    if (corriente <= 5)
    {
        Console.WriteLine("MEDICIÓN NORMAL");
        normales = normales + 1;
    }
    else
    {
        Console.WriteLine("SOBRECORRIENTE DETECTADA");
        sobrecorrientes = sobrecorrientes + 1;
    }
}

double promedio = suma / 8.0;

Console.WriteLine();
Console.WriteLine($"Corriente promedio: {promedio:F2} A");
Console.WriteLine($"Mediciones normales: {normales}");
Console.WriteLine($"Sobrecorrientes detectadas: {sobrecorrientes}");

if (sobrecorrientes == 0)
{
    Console.WriteLine("ACTUADOR APROBADO");
}
else
{
    Console.WriteLine("ACTUADOR REQUIERE REVISIÓN");
}