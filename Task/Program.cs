// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palindrom(int num)
{
    if (num > 99999 || num < 10000)
    {
        return "Введено неправильное число";
    }
    else
    {
        string res = "";
        int[] array = new int[5];
        for (int i = 0; i < 5; i++)
        {
            array[i] = num % 10;
            num = num / 10;
        }
        if (array[0] == array[4] && array[1] == array[3])
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
}

try
{
    Console.Write("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write(Palindrom(num));
}
catch
{
    Console.WriteLine("Введено некорректное число");
}