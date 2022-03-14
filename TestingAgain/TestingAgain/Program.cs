

using TestingAgain;

Console.WriteLine("Hello, World!");
Console.WriteLine("=================");


try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2022, 11, 11));
    Console.WriteLine(new Date(2022, 2, 456));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
