// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
System.Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {A} в степени {B} = {aInB(A, B)}");
*/
int aInB(int a, int b) // возвращает a в степени b
{
    int result = a;
    for (int i = 2; i <= b; i++)
        result *= a;
    return result;
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Cумма цифр числа {number} = {sum(number)}");
*/
int sum(int a) //возвращает сумму цифр числа а
{
    int result = 0;
    string aString = Convert.ToString(a);
    for (int i = 0; i < aString.Length; i++)
        result += Convert.ToInt32(Convert.ToString(aString[i])); // тут сделал так потому что прямиком из Char в Int32 конвертирует неверно, было бы интерсно кстати узнать почему
    return result;
}


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
/*
System.Console.Write("Введите максимальное число в массиве: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"[{String.Join("; ", randomArray(maxNumber))}]"); 
*/
int[] randomArray(int max) // принимает максимальное число, допустимое в массиве, возвращает массив длиной 8, заполненный рандомно с максимумом = max
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(max + 1);
    return array;
}
