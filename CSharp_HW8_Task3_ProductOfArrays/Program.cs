// Задача 58: Задайте два двумерных массива (от 0 до 10). 
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4 
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

Console.Clear();

int[,] Fill2DimArray(int numOfRows, int numOfColumns)
{
    int[,] arrayRandom = new int[numOfRows, numOfColumns];
    for (int i = 0; i < arrayRandom.GetLength(0); i++)
    {
        for (int j = 0; j < arrayRandom.GetLength(1); j++)
        {
            arrayRandom[i, j] = new Random().Next(0, 10);
        }
    }
    return arrayRandom;
}

void Print2DimArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayForPrint[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProductOfArrays(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] resultArray = new int[arrayFirst.GetLength(0), arrayFirst.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFirst.GetLength(1); j++)
        {
            resultArray[i, j] = arrayFirst[i ,j] * arraySecond[i, j];
        }
    }
    return resultArray;
}


Console.Write("Введите количество строк в массивах: ");
int numOfRowsArray = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массивах: ");
int numOfcolumnsArray = int.Parse(Console.ReadLine());

int[,] arrayTwoDimFirst = Fill2DimArray(numOfRowsArray, numOfcolumnsArray);
Console.WriteLine("Первый массив: ");
Print2DimArray(arrayTwoDimFirst);

int[,] arrayTwoDimSecond = Fill2DimArray(numOfRowsArray, numOfcolumnsArray);
Console.WriteLine("Второй массив: ");
Print2DimArray(arrayTwoDimSecond);

int[,] arrayProductFirstSecond = ProductOfArrays(arrayTwoDimFirst, arrayTwoDimSecond);
Console.WriteLine("Результирующий массив: ");
Print2DimArray(arrayProductFirstSecond);