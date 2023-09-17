/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

string PrintNumer(int num, string res)
{
    if (num == 1)
    {
    res = '1'+ res;
    return res;
    }
    else
    {
    res =  num + res;
    return PrintNumer(num - 1, res);
    }
}
string result = "";

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumer(number, result);
Console.WriteLine(result);
*/


// string PrintNumbers(int start, int end)
// {
// if (start == end) return start.ToString();
// return (start + " " + PrintNumbers(start + 1, end));
// }

/* Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8


int PowerAB ( int a, int b, int res)
{
    if (b == 0)
        return 1;
    return a* PowerAB(a,b-1);
}
Console.WriteLine(PowerAB(5,3));
*/

/*Задача 67: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

int SumDigits(int number)
{
    if (number == 0)
        return 0;
    else    
        return number % 10 + SumDigits(number / 10);
}

Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));
*/

/* Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumer(int num, string res)
{
    if (num == 1)
    {
    res = res + '1';
    return res;
    }
    else
    {
    res = res + num;
    return PrintNumer(num - 1, res);
    }
}
string result = "";

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumer(number, result);
Console.WriteLine(result);
*/

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int PowerAB ( int M, int N)
{
    if(M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + PowerAB(M, N - 1);  
    else return N + PowerAB(M, N + 1);  
}
Console.WriteLine(PowerAB(1,5));