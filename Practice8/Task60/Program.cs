/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] Fill3DArrayUniq(int a, int b, int c){
    int[,,] mat = new int[a,b,c];
    Dictionary<int, bool> dict = new Dictionary<int, bool>();    
    Random rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                int randomValue = rnd.Next(10,99);
                while (dict.ContainsKey(randomValue)){
                    randomValue = rnd.Next(10,99);
                }                
                mat[i,j,k] = randomValue;
                dict.Add(randomValue, true);
            }            
        }
    }
    return mat;
}

void Print3DMatrixVerbose(int[,,] mat){
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            for (int k = 0; k < mat.GetLength(2); k++)
            {
                Console.Write($"{mat[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();           
        }  
        Console.WriteLine("===========");      
    }
}


//int[,,] matrix3D = Fill3DArrayUniq(2,2,2);
Print3DMatrixVerbose(Fill3DArrayUniq(2,2,2));