
Console.Clear();

Console.WriteLine("Сколько рублей Вы хотели бы обменять на юани?");
double rubls = Convert.ToDouble(Console.ReadLine());

double CNY = rubls * 0.11448;

Console.WriteLine($"На {rubls} рублей Вы сможете купить {CNY} юаней.");
Console.Read();