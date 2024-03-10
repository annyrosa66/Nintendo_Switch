// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operacion suma y resta");
Console.WriteLine();

Console.WriteLine("Elija una opcion (suma = s | Resta = r)");
char operacion = Convert.ToChar(Console.ReadLine());

switch (operacion)
{
    case 's':
        Console.WriteLine("Ha seleccionado la opcion suma");
        break;
    case 'r':
        Console.WriteLine("Ha seleccionado la opcion resta");
        break;
    default:
        Console.WriteLine("Ha seleccionado la opcion incorrecta");
        break;

       
}
Console.WriteLine("Programa terminado");