// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] Fill3DimArray(int numOfX, int numOfY, int numOfZ)
{
    int[] tempArray = new int[numOfX * numOfY * numOfZ];
    int[,,] array3D = new int[numOfX, numOfY, numOfZ];
    int countArray = 0;

    tempArray[0] = new Random().Next(10, 100);

    for (int i = 1; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(10, 100);
        bool checkRepeat = false;
        while (!checkRepeat)
        {
            for (int j = 0; j < i; j++)
            {
                if (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 100);
                    j = 0;
                }
                else
                {
                    checkRepeat = true;
                }
            }
        }
    }

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = tempArray[countArray];
                countArray++;
            }
        }
    }

    return array3D;
}

void Print3DimArray(int[,,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayForPrint.GetLength(2); k++)
            {
                Console.Write($"{arrayForPrint[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Write("Введите 1-ю размерность массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите 2-ю размерность массива: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите 3-ю размерность массива: ");
int z = int.Parse(Console.ReadLine());

int[,,] array3Dim = Fill3DimArray(x, y, z);

Print3DimArray(array3Dim);