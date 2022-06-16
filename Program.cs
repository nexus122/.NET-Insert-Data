Console.WriteLine("¿Cual Es tu nombre?");

var name = Console.ReadLine();
var currentDate = DateTime.Now;

// {Environment.NewLine} Esto genera una nueva linea en la consula!
Console.WriteLine($"{Environment.NewLine} {currentDate:d} - {currentDate:t} -> Saludos, {name}!");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);