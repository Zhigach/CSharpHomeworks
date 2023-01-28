/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] CreateRandomArray(double low, double high, int size){
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++){        
        arr[i] = rnd.NextDouble()*10 - 5;
    }
    return arr;
}

double GetMax(double[] arr){
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++){
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

double GetMin(double[] arr){
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++){
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

double[] array = CreateRandomArray(-99, 99, 5);
Console.WriteLine($"Difference between maximum and minimum elements in [{string.Join(", ", array)}] is {GetMax(array) - GetMin(array)}");