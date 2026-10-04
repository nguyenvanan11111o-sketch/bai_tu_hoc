using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap N: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Cac so nguyen to tu 2 den " + n + " la: ");

        for(int i = 2; i <= n; i++)
        {
            int dem = 0;
            for(int j = 1; j <= i; j++)
            {
                if(i % j == 0)
                {
                    dem ++;
                }
            }
            if(dem == 2)
                {
                    Console.Write(i + " ");
                }
        }
    }
}
