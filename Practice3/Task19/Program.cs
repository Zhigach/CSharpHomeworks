/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int getNumberFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 99999){
            break;
        } else {
            Console.WriteLine("You've entered incorrect number. Try again ;)");
        }
    }
    return result;
}

bool isPolyndrome(int number){
    if (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10){
        return true;
    }
    return false;
}

int N = getNumberFromUser("Enter five digit number (from 10000 to 99999):");
if (isPolyndrome(N)){
    Console.WriteLine($"Number {N} is a polyndrome");
} else {
    Console.WriteLine($"Number {N} isn't a polyndrome");
}