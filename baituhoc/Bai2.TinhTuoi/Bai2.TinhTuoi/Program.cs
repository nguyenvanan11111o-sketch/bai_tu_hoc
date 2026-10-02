using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap nam sinh cua ban: ");
        int namsinh = int.Parse(Console.ReadLine() ?? "0");

        int nam_hien_tai = 2026;
        int tuoi = nam_hien_tai - namsinh;

        Console.WriteLine("Tuoi cua ban la: " +  tuoi);
    }
}