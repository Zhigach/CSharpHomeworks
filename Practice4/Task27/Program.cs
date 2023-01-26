/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
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

int sumDigits(int number){
    int result = 0;
    while (number > 0){
        result += number % 10;
        number /= 10;
    }
    return result;
}

int n = getNumberFromUser("Enter an integer number", 0);

Console.WriteLine($"Summ of digits in {n} is {sumDigits(n)}");