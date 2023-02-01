/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
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

double GetIntersectionX(int k1, int b1, int k2, int b2)
{
    return (double)(b2-b1)/(double)(k1-k2);
}

Console.WriteLine("Provide parameters for two straight lines 1) y = k1 * x + b1, 2) y = k2 * x + b2");
int k1 = getNumberFromUser("Enter an integer number for k1", int.MinValue);
int b1 = getNumberFromUser("Enter an integer number for b1", int.MinValue);
int k2 = getNumberFromUser("Enter an integer number for k2", int.MinValue);
int b2 = getNumberFromUser("Enter an integer number for b2", int.MinValue);

double xCoord = GetIntersectionX(k1,b1,k2,b2);

Console.WriteLine($"Straight lines 1) y = {k1} * x + {b1}, 2) y = {k2} * x + {b2} intersect at point ({xCoord}; {k1*xCoord+b1})");

