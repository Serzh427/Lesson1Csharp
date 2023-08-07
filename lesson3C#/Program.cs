/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

int show2number ( int num )
{
    int thirdNumber = num % 100;
    int secondNumber = thirdNumber / 10;
    return secondNumber;
}

int randomizer = new Random().Next(100,999);
int newNumber = show2number(randomizer);
Console.WriteLine ($"New version of {randomizer} is {newNumber}");
*/

/* Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа
 ( или -1, если третьей цифры нет).

int needNumber ( int num )
{
    
    while (num > 999)
    {
        num /= 10;
    }
    return  num % 10;
}
int randomizer = new Random().Next();
int newNumber = needNumber(randomizer);
if ( randomizer < 100 )
{
    Console.WriteLine ($"New number is {randomizer} and answer is -1");
}
else
{
    Console.WriteLine ($"New version of {randomizer} is {newNumber} ");
}
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

Console.Write("Input number of day week today: ");
int validDay = Convert.ToInt32(Console.ReadLine());
if ( validDay > 5 && validDay <=7 )
    {
        Console.WriteLine("выходной");
    }
    else
    {
         if ( validDay > 0 && validDay < 6)
        {
        Console.WriteLine("опять работа");
        }
        else
        {
        Console.WriteLine("укажите цифру от 1 до 7");
        }  
     
    }      
*/

// Homework lesson 3


/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.


bool palindrom ( string num )
{
    int len = num.Length;
    for (int i = 0; i < len/2; i++ )
    {
        if (num[i] != num [len -i -1])
        return false;
    }
    return true;
}
Console.Write("Input your number: ");
string newN = Console.ReadLine();
bool result = palindrom(newN);
Console.Write(result);
*/

/* Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

void square (string msg, int N)
{   for ( int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i}*{i}*{i} = {i*i*i}");
    }
    Console.WriteLine();
}
Console.Write("input your N: ");
int newN = Convert.ToInt32(Console.ReadLine());
square(msg: "", N: newN);
*/

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.


void sqrtXYZ ( int x1, int y1, int z1, int x2, int y2, int z2)
{
    Console.WriteLine($"{Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1)))}");
}

int text ( string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int X1 = text("Input x1: ");
int X2 = text("Input x2: ");
int Y1 = text("Input y1: ");
int Y2 = text("Input y2: ");
int Z1 = text("Input z1: ");
int Z2 = text("Input z2: ");
sqrtXYZ ( X1,  Y1, Z1, X2,Y2, Z2);

*/