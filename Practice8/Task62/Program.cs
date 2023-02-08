/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

bool IsAvailable(int[,] mat, int r, int c){ // treats 0 as available (not used) cells
    return (r > -1 && c > -1 && r < mat.GetLength(0) && c < mat.GetLength(1) && mat[r,c] == 0);
}

int[,] Fill2dMatrixSpiral(int a, int b){
    int[,] mat = new int[a,b];
    int counter = 1;
    int i = 0;
    int j = 0;
    int deli = 0;
    int delj = 1;
    mat[i,j] = counter;
    while (true){  
        while (IsAvailable(mat, i+deli, j+delj)){
            i += deli;
            j += delj;
            mat[i,j] = ++counter;
        }
        if (IsAvailable(mat, i, j+1)){            
            deli = 0;
            delj = 1;
        } else if (IsAvailable(mat, i+1, j)){            
            deli = +1;
            delj = 0;
        } else if (IsAvailable(mat, i, j-1)){
            deli = 0;
            delj = -1;
        } else if (IsAvailable(mat, i-1, j)){
            deli = -1;
            delj = 0;
        } else
            break;
    }
    return mat;
}

void PrintMatrix(int[,] mat){
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if(mat[i,j] < 10)
                Console.Write(" " + mat[i,j] + " ");
            else
                Console.Write(mat[i,j] + " ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(Fill2dMatrixSpiral(4,4));
