// ================================ Двумерные массивы ===============================================
/*
int[,] doubleArray = { { 1, 2, 3}, { 4, 5, 6 } };      // 1 2 3
int[,] doubleArray1 = new int[ 2, 3 ];                 // 4 5 6
// n[0,0] n[0,1] n[0,2]                0 0 0    2 rows
// n[1,0] n[1,1] n[2,2]                0 0 0    3 cols

int[,] CreateArray(int rows, int cols, int from, int to) // генерирует массив rows*cols и заполняет рандомом from to
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array) // выводит двумерный массив в виде матрицы
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateArray(5, 6, 1, 9);
PrintArray(array);
*/
