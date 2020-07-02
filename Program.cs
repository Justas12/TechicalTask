using System;

namespace TechnicalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPyramid(4);
        }

        private static void PrintPyramid(int height)
        {
            if (height == 1)
            {
                Console.WriteLine("*");
                return;
            }
            else if (height > 1)
            {
                PrintPyramid(height - 1);
                for (int i = 0; i < height; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Bad input");
                return;
            }
        }
    }
}
