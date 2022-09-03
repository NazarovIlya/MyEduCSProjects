
Console.Clear();
string str = "4234 fgsd dbn";

try
{
    int a = int.Parse(str);
    Console.WriteLine("Конвертация прошла успешно!");
}
catch
{
    Console.WriteLine("Ошибка конвертации!");
}
// OR:

bool b = int.TryParse(str);

if(b)
    Console.WriteLine("Конвертация прошла успешно!");
Console.WriteLine("Ошибка конвертации!");