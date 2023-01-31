/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] arr = GetRandomArray(10);
PrintArray(arr);
Console.WriteLine(FindX(arr));

int FindX(int[] array)
{
    int x = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            x = x + 1;
        }
    }
    return x;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}