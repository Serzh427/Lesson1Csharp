// Seminar 2.
//Theory
/*
13254 / 10 = 1325
13254 / 100 = 132
13254 / 1000 = 13
13254 / 10000 = 1

13254 % 10 = 4
13254 % 100 = 54
13254 % 1000 = 254
13254 % 10000 = 3254
*/

/* Task 1. Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

int CutNumber(int num)
{
    int hundreds =  num / 100;
    int units = num % 10;

    int res = hundreds * 10 + units;
    return res;
    // return hundreds * 10 + units;
}

int randNumber = new Random().Next(100, 1000);
//Console.WriteLine (CutNumber(randNumber));

int newNumber = CutNumber(randNumber);
Console.WriteLine ($"New version of {randNumber} is {newNumber}");
*/

/* Task 2. Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно a и b.

bool isDividable(int num, int div1, int div2)
{
    //if ( num % div1 == 0 && num % div2 == 0)
    //    return true;
    //else
    //    return false;
     // *нижняя строка тоже самое что и верхняя*
    return num % div1 == 0 && num % div2 == 0;       
}

Console.Write("Input a number for cheking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool res = isDividable(number, divider1, divider2);
if(res) Console.Write("Yes");
else Console.Write("No");
*/

/* Task 3.  Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.

int MaxNum(int num);
{
    int hundreds = num % 10;
    int units = num / 10;
    if (units < hundreds)
    return hundreds;
    else
    return units ;   
}    
int number = new Random().Next( 10, 99);
Console.WriteLine(number);
int result = MaxNum(number);
Console.WriteLine(result);
*/ 

/* Task 4. Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
*/

