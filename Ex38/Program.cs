// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Random random = new Random();
int size = random.Next(4, 10);
double[] array = new double[size];
int multipl = 100;
FillArray(array);
PrintArray(array);
Console.WriteLine($"Max = {FindMax(array)}");
Console.WriteLine($"Min = {FindMin(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {Math.Round(FindMax(array)-FindMin(array), 2)}");


void FillArray(double[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.NextDouble() * multipl;
    }
}

void PrintArray(double[] num)

{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(Math.Round(num[i], 2) + " ");
    }
    Console.WriteLine();
}

double FindMax(double[] num)
{
    double max = num[0];
    for (int i = 1; i < num.Length; i++)
    {
        if (num[i] > max)
        {
            max = num[i];
        }
    }
    return Math.Round(max, 2);
}

double FindMin(double[] num)
{
    double min = num[0];
    for (int i = 1; i < num.Length; i++)
    {
        if (num[i] < min)
        {
            min = num[i];
        }
    }
    return Math.Round(min, 2);
}
