//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void RowsSorted(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.Clear();
int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
System.Console.WriteLine();
RowsSorted(array);
PrintArray(array);
*/
//===================================================================
//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int FindRowOfMinSum(int[,] array)
{
    int minSum = 0;
    int result = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        if (tempSum < minSum)
        {
            minSum = tempSum;
            result = i + 1;
        }
    }
    return result;
}

Console.Clear();
int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"String with the smallest amount of elements - {FindRowOfMinSum(array)}.");
*/
//===================================================================
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
    }
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int Products(int[,] array1, int[,] array2, int rowNumber, int colNumber)
{
    int result = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        result += array1[rowNumber, i] * array2[i, colNumber];
    }
    return result;
}

int[,] ProductOfMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = Products(array1, array2, i, j);
        }
    }
    return result;
}

Console.Clear();
int[,] matrixA = GetArray(5, 5, 0, 9);
PrintArray(matrixA);
System.Console.WriteLine();
int[,] matrixB = GetArray(5, 5, 0, 9);
PrintArray(matrixB);
System.Console.WriteLine();
int[,] matrixAB = ProductOfMatrix(matrixA, matrixB);
PrintArray(matrixAB);
*/
//===================================================================
//---------------**Задачи повышенной сложности**---------------------
//===================================================================
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
bool FindElement(int[,,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value) return true;
            }
        }
    }
    return false;
}

int[,,] GetArray(int a, int b, int c, int min, int max)
{
    int temp;
    int[,,] array = new int[a, b, c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                do
                    temp = new Random().Next(min, max + 1);
                while(FindElement(array, temp));
                array[i, j, k] = temp;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

Console.Clear();
System.Console.Write("Enter the dimension A: ");
int a = int.Parse(Console.ReadLine()!);
System.Console.Write("Enter the dimension B: ");
int b = int.Parse(Console.ReadLine()!);
System.Console.Write("Enter the dimension C: ");
int c = int.Parse(Console.ReadLine()!);
if (a * b * c > 90) System.Console.WriteLine("With such introductory exclusive values it will not work!"); 
else
{
    Console.Clear();
    int[,,] array = GetArray(a, b, c, 10, 99);
    PrintArray(array);
}
*/
//===================================================================
//Напишите программу, которая заполнит спирально массив 4 на 4. 
/*
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
    }
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int size)
{
    int[,] array = new int[size, size];
    int count = 10;
    int firstPosition = 0;
    int lastPosition = array.GetLength(0) - 1;
    for (firstPosition = 0; firstPosition < lastPosition; firstPosition++, lastPosition--)
    {
        for (int i = firstPosition; i < lastPosition; i++) //go right to end
        {
            array[firstPosition, i] = count++;
        }
        for (int i = firstPosition; i < lastPosition; i++) // go down to end
        {
            array[i, lastPosition] = count++;
        }
        for (int i = lastPosition; i > firstPosition; i--) // go left to 2
        {
            array[lastPosition, i] = count++;
        }
        for (int i = lastPosition; i > firstPosition; i--) // go upper to 2
        {
            array[i, firstPosition] = count++;
        }
    }
    if (firstPosition == lastPosition) 
        array[firstPosition, firstPosition] = count; // <= я 2 часа думал над этой строчкой
    return array;
}

Console.Clear();
int[,] array = GetArray(4);
PrintArray(array);
*/
