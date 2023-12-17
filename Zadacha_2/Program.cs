// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
//4 3 1  =>  4 6 2 
//2 6 9      2 6 9 
//4 6 2      4 3 1

int[,] array = new int[5, 4];

CreateArray();
PrintArray();
ReplaceFirstAndLastStrings();
PrintArray();

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

void ReplaceFirstAndLastStrings()
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array [0,i];
        array [0,i] = array [ array.GetLength(0) -1, i];
        array [ array.GetLength(0) -1, i] = temp;
    }
   
}

