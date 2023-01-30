// Выполнить с помощью рекурсии. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
/*
Console.Clear();
Console.Write("Введи число: ");
int n  = int.Parse(Console.ReadLine()!);

Console.WriteLine(NumbersNto1(n));
*/
//=====================================================================
// Выполнить с помощью рекурсии. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Clear();
Console.Write("Введи число M: ");
int m  = int.Parse(Console.ReadLine()!);
Console.Write("Введи число N: ");
int n  = int.Parse(Console.ReadLine()!);

if (m < n) Console.WriteLine(sumOfMtoN(m, n));
else Console.WriteLine(sumOfMtoN(n, m));
*/
//=====================================================================
// Выполнить с помощью рекурсии. Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9                   m = 3, n = 2 -> A(m,n) = 29
/*
Console.Clear();
Console.Write("Введи число M: ");
int m  = int.Parse(Console.ReadLine()!);
Console.Write("Введи число N: ");
int n  = int.Parse(Console.ReadLine()!);

Console.WriteLine(mrAkkerman(m, n));
*/
//=====================================================================
//============================МЕТОДЫ===================================
//=====================================================================
/*
string NumbersNto1(int n)
{
    if (n == 1)
        return n.ToString();
    return (n + " " + NumbersNto1(n - 1));
}

int sumOfMtoN(int m, int n)
{
    if (m == n)
        return m;
    return m + sumOfMtoN(m + 1, n);
    
}

int mrAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0)
        return mrAkkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return mrAkkerman(m - 1, mrAkkerman(m, n - 1));
    return 0; // возврат для некорректных (отрицательных) значениях m и n
}
*/
