using System;

namespace PascalsTriangle
{
    class Program
    {
        class Triforce
        {
            public static void Main()
            {
                int rows = 5, val = 1, b, i, j;
                Console.WriteLine("Pascal's triangle");
                for (i = 0; i < rows; i++)
                {
                    for (b = 1; b <= rows - i; b++)
                        Console.Write("  ");
                    for (j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                            val = 1;
                        else
                            val = val * (i - j + 1) / j;
                        Console.Write(val + "   ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
