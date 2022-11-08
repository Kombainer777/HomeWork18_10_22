// Написать программу копирования массива
void FillArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++) matrix[i] = new Random().Next(1, 10);
}

void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
        Console.Write($" {matrix[i]} ");
}

void CloneMatrix(int[] matrix)
{
    int[] clone = new int[matrix.Length];
    for (int i = 0; i < matrix.Length; i++)
    {
        clone[i] = matrix[i];
        Console.Write($" {clone[i]} ");
    }
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[] matrix = new int[size];

FillArray(matrix);
Console.WriteLine(" Исходный массив: ");
PrintArray (matrix);
Console.WriteLine();

Console.WriteLine(" Скопированный массив:  ");
CloneMatrix(matrix);
