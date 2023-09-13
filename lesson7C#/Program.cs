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

/* Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.

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

void ChangeRows ( int [,] array, int r1, int r2)
{
    if ( r1 >= 0 && r1 < array.GetLength(0) &&
         r2 >= 0 && r2 < array.GetLength(0) && // && аперсант если два знака то после 1-ого действия если будет ложь, if не будет выполняться вовсе.
         r1 != r2)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
             int temp = array[r1,j];
             array[r1, j] = array[r2, j];
             array[r2,j] = temp;
        }
    }     
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write("Input a number of the first row to change: ");
int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input a number of the second row to change: ");
int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

ChangeRows( myArray, r1, r2);
Show2dArray(myArray);
*/

/* Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы.


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

void ReplaceRowsToColumns(int[,] array)
{
for(int i=0; i<array.GetLength(0); i++)
{
for(int j=0; j<array.GetLength(1); j++)
{
if(j>i)
{
int temp = array[i, j];
array[i,j]= array[j,i];
array[j,i] = temp;
}

}
}
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
ReplaceRowsToColumns(myArray);
Show2dArray(myArray);
*/

/* Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.


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

int [,] FindMinimal(int[,] array)
{
    int minI=0;
    int minJ=0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if ( array [i,j] < array [0,0] )
                
                minI = i;
                minJ = j;     
        }
    }

    int [,] result = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    for(int i=0; i<result.GetLength(0); i++)
    {
        for(int j=0; j<result.GetLength(1); j++)
        {
            if (i < minI && j < minJ) result[i,j] = array[i,j];
            if (i < minI && j >= minJ) result[i,j] = array[i,j+1];
            if (i >= minI && j < minJ) result[i,j] = array[i+1,j];
            if (i >= minI && j >= minJ) result[i,j] = array[i+1,j+1];
        }
    } 
    return result;  
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int [,]  newArray = FindMinimal(myArray);
Show2dArray(newArray);
*/

// Homework
/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

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

void SummaNumbersOfRow (int [,] array)
{
    int [] summa = new int [array.GetLength(0)];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            summa[i] = summa[i] + array[i,j];
        }
        Console.Write($"{i} строка имеет сумму = {summa[i]} ");
        Console.WriteLine();

    }
    int minI = 0;
    for(int i=0; i<summa.GetLength(0); i++)
    {
        if (summa[minI] > summa[i])
        minI = i;
    }
    Console.Write($"Наименьшая сумма элементов: {summa[minI]} находиться в строке = {minI} ");
    Console.WriteLine();
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
SummaNumbersOfRow(myArray);
*/

/* Задача 58: Задайте две матрицы. Напишите программу, к
оторая будет находить произведение двух матриц.


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

int [,] MultiplicationAr1AndAr2 (int [,] myArray1, int [,] myArray2)
{
    int [,] result = new int [myArray1.GetLength(0), myArray2.GetLength(0)];
    for(int i=0; i<result.GetLength(0); i++)
    {
         for(int j=0; j<result.GetLength(1); j++)
         {
            result[i,j] = myArray1[i,j]*myArray2[i,j];
         }
    }
    return result;
}

int[,] myArray1 = CreateRandom2dArray();
Show2dArray(myArray1);

Console.WriteLine();

int[,] myArray2 = CreateRandom2dArray();
Show2dArray(myArray2);

Console.WriteLine();

int [,] newArray = MultiplicationAr1AndAr2(myArray1, myArray2);
Show2dArray(newArray);
*/

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2


int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++) { matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k); }
        }
    }
    return matrix;
}
Random rnd = new Random();
int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool _break = false;
        value = rnd.Next(min, max + 1);
        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
        {
            if (_break) { break; }
            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
            {
                if (_break) { break; }
                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
                {
                    if (matrix[i1, j1, k1] == value) { _break = true; break; }
                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
                }
            }
        }
    }
    return value;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < matrix.GetLength(2); k++) { Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|"); }
            Console.WriteLine();
        }
    }
}
int [,,] newArray = CreateMatrix(2,2,2, 10, 99);
PrintMatrix(newArray);
*/


