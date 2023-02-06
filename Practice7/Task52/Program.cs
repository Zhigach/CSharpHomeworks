/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int[,] FillRandomMatrix(int a, int b){
    int[,] mat = new int[a,b];
    Random rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            int val = rnd.Next(0, 10);
            mat[i,j] = val;
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

double ColumnAverage(int [,] mat, int columnNumber){
    double result = 0.0;
    int size = mat.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        result += mat[i,columnNumber];
    }
    return result/size;
}

int[,] matrix = FillRandomMatrix(4, 4);
PrintMatrix(matrix);

Console.Write("Average per column are: ");
for (int i = 0; i < matrix.GetLength(1); i++)
{
    Console.Write($"{ColumnAverage(matrix, i)}, ");
}
Console.WriteLine();