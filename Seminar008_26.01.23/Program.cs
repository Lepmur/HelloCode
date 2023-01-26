//Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

void ChangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}

Console.Clear();
int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
System.Console.WriteLine();
ChangeRows(array);
PrintArray(array);
*/
//==================================================================================
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

void ChangeRowsToCols(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

Console.Clear();
int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
System.Console.WriteLine();
if (array.GetLength(0) != array.GetLength(1)) {System.Console.WriteLine("This array is not square!"); return;}
else 
{
    ChangeRowsToCols(array);
    PrintArray(array);
}
*/
//==================================================================================
// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.
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

int[] IndexesOfMin(int[,] array)
{
    int min = array[0, 0];
    int[] minIndexes = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) 
            {
                min = array[i, j];
                minIndexes[0] = i;
                minIndexes[1] = j;
            }
        }
    }
    return minIndexes;
}

void DeleteRowCol(int[,] array, int[] minIndexes)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minIndexes[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minIndexes[1]) continue;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
System.Console.WriteLine();
int[] minIndexes = IndexesOfMin(array);
DeleteRowCol(array, minIndexes);
*/
