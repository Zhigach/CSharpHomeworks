/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateRandomArray(int low, int high, int size){
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++){
        arr[i] = rnd.Next(low, high+1);
    }
    return arr;
}

int CountOddPositionsSum(int[] arr){
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2){
        sum += arr[i];
    }
    return sum;
}

int[] array = CreateRandomArray(0, 99, 5);
Console.WriteLine($"Sum of elements standing on odd positions in [{string.Join(", ", array)}] is {CountOddPositionsSum(array)}");


