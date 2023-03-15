// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

int Num(int num)
{
    int num1 = num;
    int revers = 0;
    int ost = 0;
    while (num > 0)
    {
        ost = num % 10;
        revers = revers * 10 + ost;
        num = num / 10;
    }
    return revers;
}

string Palindrom(int num)
{
    string res = "";
    if (num == Num(num))
    {
        res = "Введённое число является палиндромом";
        return res;
    }
    else
    {
        res = "Введённое число не является палиндромом";
        return res;
    }
}

try
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Palindrom(num));
}
catch
{
    Console.WriteLine("Введено некорректное число");
}