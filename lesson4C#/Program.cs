﻿/* 1. Напишите программу, которая принимает на вход число (А) и 
выдаёт сумму чисел от 1 до А.

int sumNumbers (int num)
{
    int count = 1;
    int sum = 0;
    while ( count <= num)
    {
        sum = sum + count;
        count++;
    }  
    return sum;
    // int sum = 0
    // for (int count = 1; count <= num; count++)
    // sum += count;
    // return sum;

}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int summa = sumNumbers(num);
Console.WriteLine ($"Summa of numbers between 1 and input your number is = {summa}");
*/

/* 2. Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.

int countNumbers (int num)
{
    int count = 1;
    for (; 10<= num; count++ )
        num = num / 10;
    return count;
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = countNumbers(num);
Console.WriteLine($"Count of numbers is {result} if your number is {num} ");
*/

/* 3. Напишите программу, которая принимает на вход число N и 
выдаёт произведение нечетных чисел от 1 до N.

int multiplication (int num)
{
    int result = 1;
    int count = 1;
    while ( count <= num )
    {
        result = result * count;
        count = count + 2;
    }
    return  result;
}    
Console.Write("input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int resultat = multiplication(num);
Console.WriteLine($"{resultat} and your number {num}");
*/ 

/* Theory
int[] CreateRandomArray( int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    int i = 0;
    for (; i < size; i++)
        
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
*/