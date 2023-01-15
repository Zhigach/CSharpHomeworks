/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Enter an integer number:");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) Console.WriteLine("Yes it's an even number");
else Console.WriteLine("No, it's an odd number");