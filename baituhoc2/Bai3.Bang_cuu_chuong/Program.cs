using System;

class Program
{
    static void Main()
    {
        for (int j = 1; j <= 10; j++)
        {
            for (int i = 2; i <= 9; i++)
            {
                Console.Write(i + " x " + j + " = " + (i * j) + "\t");
            }

            Console.WriteLine();
        }
    }
}

