using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "\tТип: {0, 8} |\t.NET = {1, 8} |\tРазмер = {2} MIN = {3, 30}\t| MAX =  {4}";

            Console.Title = "Типы данных в C#:";

            Console.WriteLine("\n\t\t\t\t\t Числовые (целочисленные) типы:");

            Console.WriteLine(string.Format(message, "byte", typeof(byte), sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(message, "sbyte", typeof(sbyte), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(string.Format(message, "short", typeof(short), sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(string.Format(message, "ushort", typeof(ushort), sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(string.Format(message, "byte", typeof(byte), sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(message, "byte", typeof(byte), sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(message, "byte", typeof(byte), sizeof(byte), byte.MinValue, byte.MaxValue));

            Console.WriteLine("\n\t\t\t\t\t Числовые (целочисленные) типы:");

            Console.WriteLine("\n\t\t\t\t\t Числовые (целочисленные) типы:");

            Console.ReadKey();
        }
    }
}
