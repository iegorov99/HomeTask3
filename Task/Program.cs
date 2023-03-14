// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

double Dist(int[] array1, int[] array2, int num)
{
    double res = 0;
    int i = 0;
    int p = 0;
    int res1 = 0;                                                        //Добавил переменную, в которую складываются квадраты разницы координат
    while (i < num && p < num)
    {
        res1 = res1 + (array2[p] - array1[i]) * (array2[p] - array1[i]);
        i++;
        p++;
    }
    res = Math.Sqrt(res1);
    return res;
}



Console.Write("Введите количество измерений: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 2)
    Console.WriteLine("Введено некорректное количство измерений");
else
{
    int i = 0;
    int[] array1 = new int[num];
    for (i = 0; i < num; i++)
    {
        Console.Write("Введите координаты первой точки: ");
        array1[i] = Convert.ToInt32(Console.ReadLine());
    }
    int p = 0;
    int[] array2 = new int[num];
    for (p = 0; p < num; p++)
    {
        Console.Write("Введите координаты второй точки: ");
        array2[p] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine(Dist(array1, array2, num));
}
