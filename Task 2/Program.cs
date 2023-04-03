// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такой позиции нет.
Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(-10, 10);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

Console.Write("Введите позицию элемента: ");
int[] position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
while (position[0] >= size[0] || position[1] >= size[1])
{
    Console.WriteLine("Такой позиции нет");
    Console.Write("Введите позицию элемента: ");
    position = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}

Console.WriteLine($"{matrix[position[0], position[1]]}");