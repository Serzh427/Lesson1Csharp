// Вид 1
void Method1()
{
    Console.WriteLine ("Показывает текст всего лишь");
}
Method1(); // вызвать метод

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");


// Вид 21
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method21(msg: "Текст", count: 4); // Method21( count: 4, msg: "Текст");

// Вид3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year)

// Вид4
string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;

    while ( i < count)
    {
        result = result + c;
        i++;
    }
    return result
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

