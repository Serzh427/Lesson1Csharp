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

// Task 1. Напишите программу, которая выводит случайное трёхзначное число и 
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





