/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0){
            break;
        } else {
            Console.WriteLine("Incorrect number. Try again");
        }
    } 
    return result;
}

int AckermannFunction(int a, int b){
    if (a == 0){
        return b+1;
    } else if (b == 0){
        return AckermannFunction(a-1,1);
    } else {
        return AckermannFunction(a-1, AckermannFunction(a,b-1));
    }
}


int m = GetNumber("This programm will calculate Ackermann function A(m,n).\nEnter first integer - m:");
int n = GetNumber("Enter first integer - n:");
Console.WriteLine($"Ackecrmann function of defined values {m} and {n} is: {AckermannFunction(m,n)}");