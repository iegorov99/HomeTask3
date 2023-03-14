// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = 0;
    res = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return res;
}
try
{
    Console.Write("Введите координату X1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату X2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Расстояние между точками (X1,Y1,Z1) и (X2,Y2,Z2) равно {Math.Round(Dist(x1, y1, z1, x2, y2, z2), 2)}");
}
catch
{
    Console.WriteLine("Введены некорректные координаты");
}