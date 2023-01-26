/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

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

int Pow(int A, int B){
    int result = A;
    for (int i = 0; i < B-1; i++){
        result *= A;
    }
    return result;
}

int A = getNumberFromUser("Enter an integer number", int.MinValue);
int B = getNumberFromUser("Enter a natural number (1,2,3, etc)", 1);

Console.WriteLine($"{A} raised to power of {B} equals {Pow(A,B)}");

