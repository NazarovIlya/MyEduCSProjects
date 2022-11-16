using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristamsTree
{
    internal class MerryChristmasTree
    {
        public MerryChristmasTree() { }

        public void ShowTree()
        {
            Random rnd = new Random();
            const int branches = 28;

            for (int i = 0; i < branches; i++)
            {   
                for (int z = 0; z < branches - i; z++)
                    Console.Write(" ");
                {
                    for (int j = 0; j < (2 * i + 1); j++)
                    {
                        int p = rnd.Next(1, 100);

                        if (p < 75)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("▲");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("@");
                        }
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

