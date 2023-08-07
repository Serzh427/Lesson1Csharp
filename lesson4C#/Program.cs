/* 1. Напишите программу, которая принимает на вход число (А) и 
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

// Homework
/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int up_degree ( int a, int b)
{
    int result = 1;
    int i = 0;
    while ( i < b )
    {
    result *= a;
    i++;
    }
    return result;      
}

bool error (int b)
{
    if ( b < 0)
    {
        Console.WriteLine("Степень не должна быть меньше нуля");
        return false;
    }
    return true;
}
Console.Write("Input a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int B = Convert.ToInt32(Console.ReadLine());
int degree = up_degree(A,B);
if (error(B))
{
Console.WriteLine($"New number is {degree}");
}
*/

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int sum ( int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }   
    return result;
}
Console.Write("input your number: ");
int summ = Convert.ToInt32(Console.ReadLine());
int newNumber = sum(summ);
Console.WriteLine($"Take your summa {newNumber} if your number is {summ}");
*/

/* Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int [] CreateArray (int size, int min, int max)
{
    int [] array = new int[size]; // Объявляем массив
    int i = 0;
    for (; i < size; i++)
    {
        array [i] = random.Next(min, max + 1); // Генерирует случайными числами массив
    }
    return array;
}

void PrintArray ( int[] array )
{
    Consol.Write("[");
    for ( int i = 0; i < array.Length - 1; i++ )
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}   
Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] array = GenerateArray(length, min, max);

*/