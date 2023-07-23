/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine($" Max = {num2} and Min = {num1} ");
}
else
{
    Console.WriteLine($" Max = {num1} and Min = {num2} ");
}
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if ( num1 > num2 )
{
    max = num1;
}
else
{
    max = num2;
}
if (num2 > num3)
{
    Console.WriteLine("Max = " + num2);
}
else
{
    Console.WriteLine("Max = " + num3);
}
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if ( num % 2 == 0 )
{
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("This number is odd");
}
*/