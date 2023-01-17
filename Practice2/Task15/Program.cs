/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumberFromUser(){
    Console.WriteLine("Enter number of a weekday");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool IsWeekday(int num){
    if (num > 7 || num < 1){
        Console.WriteLine("Incorrect weekday number specified");
        return false;
    } else 
        return true;
}

bool IsWeekend(int num){
    return (num > 5);
}

int day = GetNumberFromUser();

if (IsWeekday(day))
    if (IsWeekend(day))
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");