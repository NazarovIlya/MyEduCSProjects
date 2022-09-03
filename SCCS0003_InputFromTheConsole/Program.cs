Console.WriteLine("Enter user name: ");
string user = string.Empty;
user = Console.ReadLine()!;
if (user != null)
    Console.WriteLine($"Hello, {user}!");
Console.ReadKey();
