/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Давайте создадим двумерный массив из целых чисел");
Console.WriteLine("Введите пожалуйста количество строк и столбцов для данного массива через пробел! ");
string[] arr = Console.ReadLine().Split(' ');
int rows = int.Parse(arr[0]);
int colums = int.Parse(arr[1]);
int[,] array = new int[rows, colums];
Console.WriteLine("Вот созданный массив!");
FillArray(array);
PrintArray(array);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
FindArithmeticMean(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        System.Console.Write(Math.Round(sum / array.GetLength(0), 2) + "\t");
    }
}

