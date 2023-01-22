/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int getNumberFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1){
            break;
        }            
        else{
            Console.WriteLine("You've entered incorrect number");
        }
    }
    return result;
}

void printCubes(int a){
    for (int i = 1; i <= a-1; i++){
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.WriteLine(Math.Pow(a, 3));
}

int N = getNumberFromUser("Enter an integer number (1 and bigger)");
printCubes(N);