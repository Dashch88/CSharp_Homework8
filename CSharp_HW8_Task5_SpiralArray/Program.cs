// Доп.Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] Fill2DimArray(int numOfRows, int numOfColumns)
{
    int[,] arraySpiral = new int[numOfRows, numOfColumns];
    int count = 1;
    int i = 0;
    int j = 0;

    while (count <= arraySpiral.GetLength(0) * arraySpiral.GetLength(1))
    {
        arraySpiral[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < arraySpiral.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= arraySpiral.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > arraySpiral.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }

    return arraySpiral;
}

void PrintSpiralArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            if (arrayForPrint[i, j] < 10)
            {
                Console.Write($"0{arrayForPrint[i, j]} ");
            }
            else
            {
                Console.Write($"{arrayForPrint[i, j]} ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк и столбцов в массиве: ");
int numOfArray = int.Parse(Console.ReadLine());

int[,] arraySp = Fill2DimArray(numOfArray, numOfArray);
PrintSpiralArray(arraySp);