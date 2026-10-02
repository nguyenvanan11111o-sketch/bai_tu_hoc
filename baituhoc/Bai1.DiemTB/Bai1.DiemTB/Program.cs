using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap diem toan: ");
        double toan = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap diem ly: ");
        double ly = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap diem hoa: ");
        double hoa = double.Parse(Console.ReadLine() ?? "0");

        double diemtb = (toan + ly + hoa) / 3;

        Console.WriteLine("Diem trung binh: " + diemtb);
    }
}