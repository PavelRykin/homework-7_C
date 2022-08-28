/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите количество строк и столбцов в двумерном массиве через запятую!!! ");
string[] arr = Console.ReadLine().Split(',');
int rows = int.Parse(arr[0]);
int colums = int.Parse(arr[1]);
int[,] array = new int[rows, colums];
CreateArray(array);
Console.WriteLine("Массив был создан!");
Console.WriteLine("Введите число которое вы хотите найти в созданном двумерном массиве! ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Вот созданный массив!");
PrintArray(array);
FindNumber(array, number);


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

int FindNumber(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine(number + " - Данное число в массиве найденно");
                return number;
            }
        }
    }
    Console.WriteLine(number + " - данное число в массиве не найдено");
    return number;
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
