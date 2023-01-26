/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] randArray(int size, int low, int high){
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++){
        arr[i] = rnd.Next(low, high+1);
    }
    return arr;
}

void printArray(int[] array){
    Console.Write('[');
    for (int i = 0; i < array.Length-1; i++){
        Console.Write(array[i]+", ");
    }
    Console.WriteLine(array[array.Length-1]+"]");
}

printArray(randArray(8, 0, 100));

// или вот такой вариант, который тоже возможен если верить условному изображению "ввод"-"вывод" в условии задачи

Console.WriteLine($"\n\nSecond possible realization of the task\n\n");

int getNumberFromUser(string message, int lowest){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= lowest){
            break;
        } else {
            Console.WriteLine($"You've entered incorrect number (must be higher than {lowest-1}). Try again.");
        }
    }
    return result;
}

int[] getArrayFromUser(int num){
    int[] arr = new int[num];
    for (int i = 0; i < num; i++){
        arr[i] = getNumberFromUser($"Enter {i}-th element of an array",int.MinValue);
        Console.WriteLine($"{num-i} elements more to specify");
    }
    return arr;
}

int num = 8;
int[] arr = getArrayFromUser(num);
Console.WriteLine("Your array is:");
printArray(arr);

