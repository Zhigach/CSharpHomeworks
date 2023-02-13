/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int max (int a, int b){
    return (a > b) ? a : b;
}

int min (int a, int b){
    return (a < b) ? a : b;
}


int RecursiveSum(int low, int high){
    if (high == low){
        return low;
    } else {
        return high + RecursiveSum(low, high - 1);
    }
}

int m = GetNumber("This programm will summ numbers from M to N.\nEnter first integer - M:");
int n = GetNumber("Enter first integer - N:");

Console.WriteLine($"Sum of numbers between {n} and {m} is: {RecursiveSum(min(n,m),max(n,m))}");
