// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Hello, World!");
Console.WriteLine("==============");

try
{
   
    Console.WriteLine(new Date(2022, 2, 29));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 12, 45));
}
catch (Exception error)
{

	Console.WriteLine(error.Message); 
}



