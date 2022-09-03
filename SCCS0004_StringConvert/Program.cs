
using System.Globalization;

Console.Clear();

Console.WriteLine("Enter first integer:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second integer:");
int b = Convert.ToInt32(Console.ReadLine());

int result = a + b;
Console.WriteLine($"{a} + {b} = {result}" );

Console.WriteLine("Enter first integer:");
double c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second integer:");
double d = Convert.ToInt32(Console.ReadLine());

double resultSub = c / d;
Console.WriteLine($"{c} / {d} = {resultSub}");

string str = "3,14";
double f = Convert.ToDouble(str);
Console.WriteLine(f);

//str = "3.14"; // separator!!!
//f = Convert.ToDouble(str);
//Console.WriteLine(f);
NumberFormatInfo numberFormatInfo = new NumberFormatInfo() // using System.Globalization; for use
{
    NumberDecimalSeparator = ".",
};
str = "3.14";
f = Convert.ToDouble(str, numberFormatInfo);
Console.WriteLine(f);
