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

