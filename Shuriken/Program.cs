using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan input: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < input * 2; i++)
            {
                for (int j = 0; j < input * 4; j++)
                {
                    if (j == input*2)
                    {
                        for (int k = i; k < (input*2) - 1; k++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                    }
                    else if (i >= input*4)
                    {
                        for (int k = j; k < input*4; k++)
                        {
                            Console.Write("+");
                        }
                        Console.Write("_");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < input*2; i++)
            {
                for (int j = 0; j < input*4; j++)
                {
                    if (i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
