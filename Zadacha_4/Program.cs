//  Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива
// без строки и столбца

int[,] array = new int[5, 4];

FillArray();
PrintArray(array);
int[] minElementCoordinates = FindMinElementCoordinates();
int[,] resultArray = PrepareNewArray(minElementCoordinates);
PrintArray(resultArray);

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] FindMinElementCoordinates()
{
    int min = array[0, 0];
    int x = 0;
    int y = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                x = i;
                y = j;
            }
        }
    }
    int[] coordinates = new int[] { x, y };
    return coordinates;
}

int[,] PrepareNewArray(int[] minElementCoordinates)
{
    int[,] resultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int newRow = 0;
    int newCol = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minElementCoordinates[0])
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minElementCoordinates[1])
            {
                continue;
            }
            resultArray[newRow, newCol] = array[i, j];
            newCol++;
        }
        newRow++;
        newCol = 0;
    }
    return resultArray;
}


