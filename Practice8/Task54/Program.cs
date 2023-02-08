/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortRow(int[,] mat, int row){ //bubble sort
    int size = mat.GetLength(1);
    int bearer;
    for (int i = 0; i < size-1; i++)
    {
        for (int k = 0; k < size-1 - i; k++)
        {
            if (mat[row, k+1] > mat[row, k])
            {
                bearer = mat[row, k+1];
                mat[row, k+1] = mat[row, k];
                mat[row, k] = bearer;
            }

        }
    }
}

void SortMatrixByRow(int[,] mat){    
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        SortRow(mat, row: i);
    }
}

int[,] matrix = FillArray(3,7);
PrintMatrix(matrix);
Console.WriteLine("The same matrix with elements sorted by row will be:");
SortMatrixByRow(matrix);
PrintMatrix(matrix);
