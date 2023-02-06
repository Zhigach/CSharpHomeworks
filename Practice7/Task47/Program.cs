/*

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumber(string message){
    Console.WriteLine(message);
    int result = 0;
    while (true){
        if (int.TryParse(Console.ReadLine(), out result) && result > 0){
            break;
        } else
        {
            Console.WriteLine("Incorrect number entered. Provide number above 0");
        }
    }
    return result;
}

double[,] FillRandomMatrix(int a, int b){
    double[,] mat = new double[a,b];
    Random rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            double val = Math.Round(rnd.NextDouble()*20 - 10, 1);            
            mat[i,j] = val;
        }
    }
    return mat;
}

void PrintMatrix(double[,] mat){
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write(mat[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Choose first matrix dimension - m");
int n = GetNumber("Choose second matrix dimension - n");

double[,] matrix = FillRandomMatrix(m,n);
PrintMatrix(matrix);


