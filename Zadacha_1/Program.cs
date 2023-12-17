//Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.
//Пример
//4 3 1         (1,2)  => 9  
//2 6 9
int[,] array = new int[5, 4];

CreateArray();
PrintArray();
int[] coordinates = AskCoordinates();
ShowValue(coordinates);

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

int[] AskCoordinates()
{
    Console.WriteLine("Введите координату x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[] { x, y };
    return arr;
}

void ShowValue(int [] coordinates)
{
    int x = coordinates[0];
    int y = coordinates[1];

    if (x < 0 || x >= array.GetLength(0))
    {
        Console.WriteLine("Значение x выходить за пределы массива");
    }
    else if (y < 0 || y >= array.GetLength(1))
    {
        Console.WriteLine("Значение y выходить за пределы массива");
    }
    else
    {
        Console.WriteLine($"Значение элемента ({x}, {y}): {array[x, y]}");
    }
}

