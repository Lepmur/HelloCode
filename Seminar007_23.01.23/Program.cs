// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

// -------------------Методы---------------------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/



// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
/*
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
*/


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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

void ArrayCow(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if (i % 2 ==0 && j % 2 ==0 )
                array[i,j] *= array[i,j];
        }
    }
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
                Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
System.Console.WriteLine();
ArrayCow(array);
PrintArray(array);
*/



//Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

int ArrayCow(int[,] array){
    int sum =0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if (i == j)
                sum += array[i,j];
        }
    }
    return sum;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
                Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(ArrayCow(array));
*/
