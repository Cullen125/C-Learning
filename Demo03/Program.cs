using System;

namespace Demo03;
class Program
{
    static void Main(string[] args)
    {
        double B = 30.30, L = 114.45, H = 50;
        CoorTrans trans = new CoorTrans();
        double X, Y, Z;

        trans.BLH2XYZ(B, L, H, out X, out Y, out Z);
        Console.WriteLine("BLH -> XYZ 结果：");
        Console.WriteLine($"X = {X}");
        Console.WriteLine($"Y = {Y}");
        Console.WriteLine($"Z = {Z}");

        trans.XYZ2BLH(X, Y, Z, out B, out L, out H);
        Console.WriteLine("XYZ -> BLH 反算结果：");
        Console.WriteLine($"B = {B}");
        Console.WriteLine($"L = {L}");
        Console.WriteLine($"H = {H}");

        Console.ReadKey();
    }
}