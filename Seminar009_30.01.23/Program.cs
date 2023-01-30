// Задача 63: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от 1 до N.
/*
Console.Write("Введи число: ");
int N  = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(1,N));

string PrintNumbers(int start, int end)
{
    if(start == end) 
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}
*/
//=====================================================================
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
/*
string NaturalFromTo(int start, int end)
{
    if(start == end) 
        return start.ToString();
    return (start + " " + NaturalFromTo(start + 1, end));
}

Console.Clear();
Console.Write("Введи число M: ");
int m  = int.Parse(Console.ReadLine()!);
Console.Write("Введи число N: ");
int n  = int.Parse(Console.ReadLine()!);
Console.WriteLine(NaturalFromTo(m, n));
*/
//=====================================================================
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int sumOfNumber(int number)
{
    if(number > 9) 
        return number % 10 + sumOfNumber(number / 10);
    return number;
}

Console.Clear();
Console.Write("Введи число: ");
int n  = int.Parse(Console.ReadLine()!);
Console.WriteLine(sumOfNumber(n));
*/
//=====================================================================
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
/*
int Power(int a, int b)
{
    if (b > 1)
        return a *= Power(a, b - 1);
    return a;
}

Console.Clear();
Console.Write("Введи число A: ");
int a  = int.Parse(Console.ReadLine()!);
Console.Write("Введи число B: ");
int b  = int.Parse(Console.ReadLine()!);
Console.WriteLine(Power(a, b));
*/
//=====================================================================
// Найдите факториал числа c помощью рекурсии
/*
int Fact(int a)
{
    if (a > 1)
        return a * Fact(a - 1);
    return a;
}

Console.Clear();
Console.Write("Введи число A: ");
int a  = int.Parse(Console.ReadLine()!);
Console.WriteLine(Fact(a));
*/
