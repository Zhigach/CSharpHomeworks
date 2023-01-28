/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] CreateRandomArray(int low, int high, int size){
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++){
        arr[i] = rnd.Next(low, high+1);
    }
    return arr;
}

int CountEvenElements(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] % 2 == 0){
            count++;
        }
    }
    return count;
}

int[] array = CreateRandomArray(100, 999, 10);

Console.WriteLine($"Number of even numbers in [{string.Join(", ", array)}] is {CountEvenElements(array)}");
