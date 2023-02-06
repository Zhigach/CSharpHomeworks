/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/

int GetNumber(string message){
    Console.Write(message+" ");
    int result = 0;
    while (true){
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0){
            break;
        } else
        {
            Console.WriteLine("Incorrect number entered. Provide positive");
        }
    }
    return result;
}

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

void PrintMatrixElement(int[,] mat, int i, int j){
    if (i > -1 && i < mat.GetLength(0) && j > -1 && j < mat.GetLength(1)){
        Console.WriteLine(mat[i,j]);
    } else 
    {
        Console.WriteLine("Element with such indecies doesn't exist");
    }
    
}

int[,] matrix = FillRandomMatrix(4, 4);
PrintMatrix(matrix);

Console.WriteLine("Choose element to print");
int m = GetNumber("Enter row index:");
int n = GetNumber("Enter column index:");

PrintMatrixElement(matrix, m, n);