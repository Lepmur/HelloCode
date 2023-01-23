//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateDoubleArray(int rows, int cols)
{
    double[,] array = new double[rows,cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(-9,10), 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Enter number of rows: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.Write("Enter number of cols: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();
double[,] array = CreateDoubleArray(m, n);
PrintArray(array);
*/


// Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, 
// а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
/*
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void FindNumber(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number)
            {
                System.Console.WriteLine($"The number {number} was found under indices [ {i}, {j} ].");
                return;
            }
                
        }
    }
    System.Console.WriteLine($"There is no number {number} in the array.");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.Write("Enter the desired number: ");
int number = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();
int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
System.Console.WriteLine();
FindNumber(array, number);
*/


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

double[] Average(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    int count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[j] += (double)array[i,j];
            count++;
        }
        result[j] /= (double)count;
        count = 0;
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.Write("Enter number of rows: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.Write("Enter number of cols: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine();
int[,] array = GetArray(m, n, 0, 9);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"The arithmetic mean of column: [ {String.Join("; ", Average(array))} ]");
*/
