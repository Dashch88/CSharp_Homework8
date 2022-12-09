// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
}

void RowMinSum(int[,] arrayMinSumRow)
{
    int sumRowMin = 0;
    int numOfMinRow = 0;
    for (int j = 0; j < arrayMinSumRow.GetLength(1); j++)
    {
        sumRowMin += arrayMinSumRow[0, j];
    }
    for (int i = 1; i < arrayMinSumRow.GetLength(0); i++)
    {
        int sumRowMinTemp = 0;
        for (int j = 0; j < arrayMinSumRow.GetLength(1); j++)
        {
            sumRowMinTemp += arrayMinSumRow[i, j];
        }
        if (sumRowMinTemp < sumRowMin)
        {
            sumRowMin = sumRowMinTemp;
            numOfMinRow = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в массиве находится в {numOfMinRow + 1}-й строке и равна: {sumRowMin}");
}

Console.Write("Введите количество строк в массиве: ");
int numOfRowsArray = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int numOfcolumnsArray = int.Parse(Console.ReadLine());

int[,] arrayTwoDimRandom = Fill2DimArray(numOfRowsArray, numOfcolumnsArray);
Print2DimArray(arrayTwoDimRandom);

RowMinSum(arrayTwoDimRandom);