/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] arr = GetRandomArray(10);
PrintArray(arr);
Console.WriteLine(FindX(arr));

double FindX(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max - min;
}

double[] GetRandomArray(int length)
{
    double[] result = new double[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-99, 100);
    }
    return result;
}

void PrintArray(double[] arr)
{
    foreach (double item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}