Console.WriteLine("Mostrar una tabla donde las filas sean del 1 al 4 y las columnas del 1 al 4.");
for (int i = 0; i <= 4; i++)
{
    for (int j = 0; j <= 4; j++)
    {
        Console.Write(i * j + "\t");
    }
    Console.WriteLine();
}
