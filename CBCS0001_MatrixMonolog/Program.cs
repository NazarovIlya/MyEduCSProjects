
//Console.BackgroundColor = ConsoleColor.Black;
//Console.ForegroundColor = ConsoleColor.Green;
//Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

using System.Drawing;

IntPtr hConsole = GetStdHandle(-11);
SetConsoleDisplayMode(hConsole, 1, out COORD b1);
Console.ReadLine();


Console.Clear();
Console.WriteLine("Wake up, Neo...");
Console.ReadLine();

Console.Clear();
Console.WriteLine("The Matrix has you...");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Follow the white rabbit.");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Knock, knock, Neo.");
Console.ReadLine();