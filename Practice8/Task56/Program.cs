/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int[,] FillArray(int a, int b){
    int[,] mat = new int[a,b];
    Random rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            mat[i,j] = rnd.Next(0,10);
        }
    }
    return mat;
}

void PrintMatrix(int[,] mat){
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write(mat[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int GetMinimalRowIndex(int[,] mat){
    int[] rowSums = new int[mat.GetLength(0)];
    int minValue = int.MaxValue;
    int minIndex = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {        
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            rowSums[i] += mat[i,j];
        }
        if (rowSums[i] < minValue){
            minValue = rowSums[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] matrix = FillArray(5,4);
PrintMatrix(matrix);
Console.WriteLine($"Row with index {GetMinimalRowIndex(matrix)} has minimal sum of elements");