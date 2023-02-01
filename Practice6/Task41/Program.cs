/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

вводим через один Enter (разбиваем через Split())

*/

int[] GetArrayFromUser()
{
    Console.WriteLine("Enter an array of integer numbers separated by space and hit ENTER:");
    string[] result = Console.ReadLine().Split(" ");
    int[] intArr = new int[result.Length];
    for (int i = 0; i < result.Length; i++)
        intArr[i] = int.Parse(result[i]);
    return intArr;
}

int CountPositiveNumbers(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            cnt++;
    }
    return cnt;
}

int[] array = GetArrayFromUser();
Console.WriteLine($"Array [{String.Join(", ", array)}] contains {CountPositiveNumbers(array)} positive numbers");