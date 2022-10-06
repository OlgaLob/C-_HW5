// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
Random random = new Random();
int size = random.Next(4, 10);
int[] array = new int[size];
FillArray(array, -100, 100);
PrintArray(array);
Console.WriteLine("Сумма элементов, находящихся на нечетных позициях, " + GetSumIndex(array));

void FillArray(int[] num, int minValue = 0, int maxValue = 150)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] num)

{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}

int GetSumIndex(int[] num)
{
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += num[i];
        }
    }
    return sum;
}