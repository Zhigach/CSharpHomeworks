/*
Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Enter an integer number:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Answer:");

for (int i = 2; i <= N; i+=2){
    Console.Write(i + ", ");
}