// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string Cube(int num)
{
    string res = "1";
    int i = 2;

    while (i <= num)
    {
        res = res + ", " + Convert.ToString(i * i * i);
        i++;
    }
    return res;

}

try
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num <= 0)
        Console.WriteLine("Введено некорректное число");
    else
        Console.WriteLine($"Кубы чисел от 1 до {num}: {Cube(num)}");
}
catch
{
    Console.WriteLine("Введено некорректное число");
}