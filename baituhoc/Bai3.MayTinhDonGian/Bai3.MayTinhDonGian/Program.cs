using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap so nguyen a: ");
        int a = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Nhap so nguyen b: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        int tong = a + b;
        int hieu = a - b;
        int tich = a * b;
        float thuong = (float)a / b;
        int du = a % b;

        Console.WriteLine("Tong a + b = " + tong);
        Console.WriteLine("Hieu a - b = " + hieu);
        Console.WriteLine("Tich a * b = " + tich);
        Console.WriteLine("Thuong a : b = " + thuong);
        Console.WriteLine("Chia lay du a % b = " + du);
    }
}