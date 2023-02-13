/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0){
            break;
        } else {
            Console.WriteLine("Incorrect number. Try again");
        }
    } 
    return result;
}

string RecursivePrint(int n){
    if (n ==  1){
        return "1";     
    } else {
        return n.ToString() + ", " + RecursivePrint(n-1);
    }
}

int number = GetNumber("Enter an integer number:");
Console.WriteLine(RecursivePrint(number));
