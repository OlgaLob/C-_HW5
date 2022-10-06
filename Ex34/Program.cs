// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Random random = new Random();
int size = random.Next(4, 10);
int[] array = new int[size];
FillArray(array, 100, 999);
PrintArray(array);
Console.WriteLine("Количество четных чисел в массиве " + EvenCountArray(array));

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

int EvenCountArray(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

