// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] arr=new int[10];
FillArray(arr);
int[] arrWithOdds=NewArrWithOdds(arr);
//PrintArray(arr);
PrintArray(arrWithOdds);
Console.WriteLine($"Сумма нечетных равна = {SumOdds(arrWithOdds)}");


void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
}
int[] NewArrWithOdds(int[] array)
{
    int[]arrForOdds=new int[10];
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]%2!=0)arrForOdds[i]=array[i];
    }
    return arrForOdds;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
int SumOdds(int[] array)
{
    int sum=default;
    for(int i=0;i<array.Length;i++)
    {
        sum+=array[i];
    }
    return sum;
}