/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumberFromUser(){
    Console.WriteLine("Enter three digit integer number (like 111, 123, 987, etc.)");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetSecondDigit(int number){
    int secondDigit = (number % 100) / 10;
    return secondDigit;
}

int input = GetNumberFromUser();
int secondDigit = GetSecondDigit(input);
Console.WriteLine($"The second digit of number {input} is {secondDigit}");

