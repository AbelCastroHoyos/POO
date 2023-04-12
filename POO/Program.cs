// See https://aka.ms/new-console-template for more information
using POO;

Console.WriteLine("Hola Programación orientada a objetos!");
Console.WriteLine("======================================");


try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(2023, 2, 2));
	Console.WriteLine(new Date(2023, 11, 31));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}

