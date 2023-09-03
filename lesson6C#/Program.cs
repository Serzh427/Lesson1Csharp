/* 1. Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue,maxValue + 1);

    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

void ReverseArray ( int [] array)
{
    for ( int i = 0; i < array.Length / 2; i++ )
    {
        int temp = array [i];
        array[i] = array [array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void ReverseArray2 (int[] array)
{
    for (int i = 0, j = array.Length -1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
WriteArray(myArray);
ReverseArray2(myArray);
WriteArray (myArray);
*/

/* 2. Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.


bool triangle (int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}

Console.Write("Input length of side a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input length of side b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input length of side c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (triangle(a,b,c)) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/

/* 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.

int [] CreateArray (int size)
{
    int [] array = new int [size];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < array.Length; i++)
        array[i] = array[i - 1] + array[i - 2];

    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
WriteArray(myArray);
*/

/* 4. Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.


int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue,maxValue + 1);

    return array;
}

Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] myArray = CreateRandomArray(size, minValue, maxValue);
WriteArray(myArray);

int [] CopyArray ( int size, int [] firstArray )
{
    int [ ] secondArray = new int[size];
    for ( int i = 0; i < size; i++)
    {
        secondArray[i] = firstArray [i];
    }
    return secondArray;
}

int [] CopyMyArray = CopyArray(size, myArray);
WriteArray (CopyMyArray);

myArray[0] =  0; // проверка, связаны ли два масива
WriteArray(myArray);
WriteArray (CopyMyArray);
*/

/* Homework
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int [] InputArray (int size)
{
    int [] array = new int [size];

    for (int i = 0; i < array.Length; i++)
        array[i] = Prompt($"Введите {i+1}-й элемент: ");

    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"a{i} = (array{i})");

    Console.WriteLine();
}

int positive (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count;  
}

int length = Prompt("Input quantity elements");
int [] array;
array = InputArray(length);
WriteArray(array);
Console.WriteLine($"Кол-во числе больше 0 - (positive(array))");
*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
int k = 0;
int b = 1;
int LINE1 = 1;
int LINE2 = 2;
double [] Array1 = InputArray(LINE1);
double [] Array2 = InputArray(LINE2);
int X_COORD = 0;
int Y_COORD = 1;

double [] InputArray (int LINE)
{
    double [] array = new double [2];
        
        array[k] = Prompt($"Input k{LINE}: ");
        array[b] = Prompt($"Input b{LINE}: ");
        

    return array;
}

double [] CrossPoint (double [] Array1, double [] Array2)
{
    double [] ArrayPoint = new double [2];
    {
       ArrayPoint[0] = (Array2[1]-Array1[0])/(Array1[0]-Array2[1]);
       ArrayPoint[1] = (Array1[0]*Array2[1]-Array1[0]*Array1[1])/(Array1[0]-Array2[1]);
    }
    return ArrayPoint;
}

bool DifferentsSubjects ( double [] Array1, double [] Array2)
{
    if ( Array1[0] == Array2[0]  )
    {
        if ( Array1[1] == Array2[1] )
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

if ( DifferentsSubjects (Array1,  Array2))
{
    double [] coord = CrossPoint (Array1, Array2);
    Console.Write($"Точка пересечения уравнений y={Array1[k]}*x+{Array1[b]} и y={Array2[k]}*x+{Array2[b]}");
    Console.WriteLine($"имеет координаты ({coord[X_COORD]}),({coord[Y_COORD]})");
    
}
*/