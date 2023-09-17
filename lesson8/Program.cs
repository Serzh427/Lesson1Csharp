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

