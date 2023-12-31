﻿/* Задайте массив из m элементов, заполненный случайными числами
 из промежутка [a, b]. Найдите сумму отрицательных элементов массива.
*/
int [] CreateRandomArray (int size, int minValuem, int maxValue)
{
    int [] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValuem,maxValue + 1);

    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfNegative(int[] array)
{
    int sum = 0;

    for ( int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];

    return sum;        
}
Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m,a,b);
WriteArray(myArray);
Console.WriteLine(SumOfNegative(myArray));


/* Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.


int [] randomArray (int size, int min, int max)
{
    int [] array = new int [size];

    for ( int i = 0; i < size; i++)
        array[i] = new Random().Next(min,max+1);
    
    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int [] changeNumbers (int [] array)
{

    for ( int i = 0; i < array.Length; i++)
    array[i] *= (-1);
    return array;
}
Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = randomArray(m,a,b);
WriteArray(myArray);
WriteArray(changeNumbers(myArray));
*/

/* Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.


int [] RandomArray (int size, int min, int max)
{
    int [] array = new int [size];

    for ( int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max +1 );
    
    return array;
}

void WriteArray (int [] array)
{
     for ( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

     Console.WriteLine();
}

bool find ( int [] array, int c)
{
    for ( int i = 0; i < array.Length; i++ )
    {
        if ( c == array[i] );
        return true;
    }  
    return false;
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray (m, a, b);
WriteArray(myArray);

Console.Write("Let me find your number an array: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = find(myArray, c);
Console.WriteLine(result);
*/

/*Задайте одномерный массив из m случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [a,b].


int ElementQuantity (int[] array, int minEl, int maxEl)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] > minEl && array[i] < maxEl) count++;
    }
    return count;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int [] CreateRandomArray (int size, int minValuem, int maxValue)
{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValuem,maxValue + 1);

    return array;
}

Console.Write("Enter a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(length, minValue, maxValue);
WriteArray(myArray);

Console.Write("Enter the left border: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the right border: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ElementQuantity(myArray, a, b));
*/

// Homework

/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет
 количество чётных чисел в массиве.


int [] CreateRandomArray (int size, int minValuem, int maxValue)
{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValuem,maxValue + 1);

    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int countNumbers (int [] array )
{
    int count = 0;
    for ( int i = 0; i < array.Length; i++)
        if ( array[i] % 2 == 0)
        count += 1;
    return count;    
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value from 100 : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value to 999: ");
int b = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(m,a,b);
WriteArray(myArray);
Console.WriteLine(countNumbers(myArray));
 */

 /* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
 Найдите сумму элементов, стоящих на нечётных позициях.

int [] randomArray (int size, int min, int max)
{
    int [] array = new int [size];

    for ( int i = 0; i < size; i++)
        array[i] = new Random().Next(min,max+1);
    
    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int summa (int [] array)
{
    int sum = 0;
    for ( int i = 0; i < array.Length; i++)
        if ( i % 2 != 0 )
        sum += array[i];
    return sum;
}
Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = randomArray(m,a,b);
WriteArray(myArray);

Console.WriteLine(summa(myArray));
*/ 

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.

double [] randomArray (int size, double min, double max)
{
    double [] array = new double [size];

    for ( int i = 0; i < size; i++)
        
        array[i] = Math.Round((new Random().NextDouble()*(max - min) + min));
    
    return array;
}

void WriteArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double minNum (double [] array)
{
    double min = 0;
    for ( int i = 0; i < array.Length; i++)
        if ( min < array [i])
        min = array[i];
    return min;
}

double maxNum (double [] array)
{
    double max = 0;
    for ( int i = 0; i < array.Length; i++)
        if ( max > array [i])
        max = array[i];
    return max;
}
double distance (double [] myArray)
{
    return Math.Round(maxNum(myArray)+(minNum(myArray)),2);
}
Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a max possible value: ");
double b = Convert.ToDouble(Console.ReadLine());

double [] myArray = randomArray(m,a,b);
WriteArray(myArray);
Console.WriteLine("min: " + minNum(myArray));
Console.WriteLine("max: " + maxNum(myArray) );
Console.WriteLine("distance: " + distance(myArray));
*/