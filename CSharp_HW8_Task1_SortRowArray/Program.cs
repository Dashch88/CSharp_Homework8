// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// сортировка расчёской (состоит в сравнение элементов на больших расстояниях и потом уменьшается, затем пузырьковой)
int[,] Sort2DimArray(int[,] arrayForSorting)
{
    for (int i = 0; i < arrayForSorting.GetLength(0); i++)
    {
        // сортировка расчёской
        int step = arrayForSorting.GetLength(1) - 1;
        while (step > 1)
        {
            for (int j = 0; j + step < arrayForSorting.GetLength(1); j++)
            {
                if (arrayForSorting[i, j] < arrayForSorting[i, j + step])
                {
                    int temp = arrayForSorting[i, j];
                    arrayForSorting[i, j] = arrayForSorting[i, j + step];
                    arrayForSorting[i, j + step] = temp;
                }
            }
            step = step * 1000 / 1247; // Оптимальное значение фактора уменьшения равно 1/(1-e-φ) ≈ 1.247, где е – основание натурального логарифма, а φ – золотое сечение.
        }

        // сортировка пузырьковая
        for (int j = 1; j < arrayForSorting.GetLength(1); j++)
        {
            bool swapFlag = false;
            for (int k = 0; k < arrayForSorting.GetLength(1) - j; k++)
            {
                if (arrayForSorting[i, k] < arrayForSorting[i, k + 1])
                {
                    int temp = arrayForSorting[i, k];
                    arrayForSorting[i, k] = arrayForSorting[i, k + 1];
                    arrayForSorting[i, k + 1] = temp;
                    swapFlag = true;
                }
            }

            if (!swapFlag)
            {
                break;
            }
        }
    }
    return arrayForSorting;
}

Console.Write("Введите количество строк в массиве: ");
int numOfRowsArray = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int numOfcolumnsArray = int.Parse(Console.ReadLine());

int[,] arrayTwoDimRandom = Fill2DimArray(numOfRowsArray, numOfcolumnsArray);
Print2DimArray(arrayTwoDimRandom);

Console.WriteLine("Преобразованный массив: ");
int[,] arrayTwoDimSorted = Sort2DimArray(arrayTwoDimRandom);
Print2DimArray(arrayTwoDimSorted);