/* Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array [i,j] = new Random().Next(min, max + 1);

        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
    }
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/


/*Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aij = i+j. 
Выведите полученный массив на экран.


int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array [i,j] = i + j;

        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

/*Задайте двумерный массив. Найдите элементы, у 
которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array [i,j] = i + j;

        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void quadro (int [,] array)
{
    for (int i = 2; i < array.GetLength(0); i+=2)
    {
        for ( int j = 2; j < array.GetLength(1); j+=2)
        {
            array[i,j] = array[i,j]*array[i,j];
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
quadro(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

/*Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array [i,j] = i + j;

        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

int SumOfMain (int [,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1) i++)
        {
        result = result + array [i,j];
        if ( i == array.Getlength(0)-1 && array.GetLength(1) - 1)
        Console.Write($"{array[i,i]} = ");
        }
    return result;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write()
Console.WriteLine(SumOfMain(myArray));
*/

/* отсортировать по убыванию строки массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array [i,j] = new Random().Next(min, max + 1);

        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void SortLine (int [,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
for (int k = 0; k < array.GetLength(1) - 1; k++)
{
if (array[i,k] < array [i, k+ 1])
{
                    int temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp;
                }
            }   
        }    
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine();
SortLine(myArray);
Show2dArray(myArray);
*/

// Homework
/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

double [,] CreateRandom2dArray()
{   Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    double min = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    double max = Convert.ToDouble(Console.ReadLine());

    double [,] array = new double [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round((new Random().NextDouble()*(max - min) + min),2);

        
    return array;
}

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}


double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array [i,j] = new Random().Next(min, max + 1);

        
    return array;
}
void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
   
}

Console.WriteLine("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int y = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [x,y] ;

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);


for(int i = 0; i < myArray.GetLength(0); i++)
    {
        
        for(int j = 0; j < myArray.GetLength(1); j++)
        {
            if (i == x && j == y)
            {

                Console.WriteLine($"This is a {myArray[x,y]}");
            }
            else
            {
        
            }

        }    
    }
 */  

/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [rows,columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array [i,j] = new Random().Next(min, max + 1);

        
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

double result (int [,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            Console.Write($"{ sum / array.GetLength(0)} ");
        }
    }   return sum / array.GetLength(0);
    
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.WriteLine(result(myArray));
*/



