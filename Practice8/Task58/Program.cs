/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MatrixProduct(int[,] a, int [,] b){
    if (a.GetLength(1) != b.GetLength(0)){
        Console.WriteLine("Theese matricies can't be multiplied");
        return new int[1,1];
    }
    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < c.GetLength(0); i++)
    {
        for (int j = 0; j < c.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1); k++)
            {
                c[i,j] += a[i,k]*b[k,j];  
            }
        }        
    }
    return c;
}

int[,] matrixA = FillArray(4,7);
Console.WriteLine("First matrix is:");
PrintMatrix(matrixA);
int[,] matrixB = FillArray(5,4);
Console.WriteLine("Second matrix is:");
PrintMatrix(matrixB);
int[,] matrixC = MatrixProduct(matrixA, matrixB);
Console.WriteLine("Product of above matricies is:");
PrintMatrix(matrixC);

