// Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.
//4 3 1  => Строка с индексом 0
//2 6 9
//4 6 2 

int[,] array = new int[5, 4];

CreateArray();
PrintArray();
int[] stringsSums = CalculateStringsSums();
int result = FindMinSumsIndex(stringsSums);
Console.WriteLine("Строка с минимальной суммой - " + result);

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
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

int[] CalculateStringsSums()
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array [i,j];
        }
        arr [i] = sum;
    }
    return arr;
}


int  FindMinSumsIndex(int [] stringsSums)
{
    int min = stringsSums [0];
    int index = 0;
    for (int i = 1; i < stringsSums.Length; i++)
    {
        if (stringsSums [i] < min)
        {
            min = stringsSums [i];
            index = i;
        }
    }
    return index;
}