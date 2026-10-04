using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        int a = 0;
        int b =1;

        for(int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int c = a + b;
            a = b;
            b = c;
        }
    }
}
