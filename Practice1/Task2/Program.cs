/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Enter first integer number:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second integer number to compare with the first one:");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Answer:");

if (firstNum > secondNum){
    Console.WriteLine($"max = {firstNum}, min = {secondNum}");
} else if (secondNum > firstNum){
    Console.WriteLine($"max = {secondNum}, min = {firstNum}");
} else{
    Console.WriteLine("Numbers are equal");
}