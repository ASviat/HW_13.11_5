// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] arr = new double[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine($"{Difference(arr)}");

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-1000, 1001) / 10.0;
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
    Console.WriteLine("]");
}
double Difference(double[] array)
{
    double min = default;
    double max = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > min && array[i] > max) max = array[i];
    }
    return min + max;
}