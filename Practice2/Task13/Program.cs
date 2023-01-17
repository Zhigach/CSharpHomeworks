/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// Решил делать через числа, так интереснее, хотя можно и через string,
// который рассматривается как char[], но там нужно обрабатывать случай,
// когда пользователь начудил и ввел не число

int GetNumberFromUser(){
    Console.WriteLine("Enter an integer number");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetNumberDepth(int number){   
    int depth = 0;    
    while (number > 0){
        number = number / 10;
        depth++;
    }
    return depth;    
}

int GetThirdDigit(int number){
    int depth = GetNumberDepth(number);    
    Console.WriteLine($"Depth is {depth}");
    if (depth < 3) {
        return -1;    
    } else {       
        int divider = 1;
        for (int i = 0; i < depth-3; i++) divider*=10; //no math used        
        int thirdDigit = (number / divider) % 10;
        return thirdDigit;
    }
}

int input = GetNumberFromUser();
int thirdDigit = GetThirdDigit(input);

if (thirdDigit >= 0){
    Console.WriteLine($"Third number of {input} is {thirdDigit}");
} else {
    Console.WriteLine("There is no third digit in this number");
}