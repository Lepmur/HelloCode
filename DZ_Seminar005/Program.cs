// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray(int size) // генерация массива размера size
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

int CounterEven(int[] array) // счетчик четных чисел в array
{
    int count = 0;
    foreach (var item in array)
        if (item%2 == 0) count += 1;
    return count;
}

string Answer(int[] array, int count) // формирование строки вывода
{
    string result = $"Сгенерировался массив трёхзначных чисел: {Environment.NewLine}"
                  + $"[ {String.Join("; ", array)} ] {Environment.NewLine}"
                  + $"Из них {count} четных!";
    return result;
}

int[] numbers = CreateArray(10);
int count = CounterEven(numbers);
Console.Clear();
System.Console.WriteLine(Answer(numbers, count));
*/


//=====================================================================
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//                    [3, 7, 23, 12] -> 19
//                    [-4, -6, 89, 6] -> 0
/*
int[] CreateArray1(int size) // генерация массива размера size
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21);
    return array;
}

int SumNotEven(int[] array) // считает сумму элементов с нечётной ПОЗИЦИЕЙ :-)
{
    int sum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (i%2 == 0) sum += array[i];
    }
    return sum;
}

string Answer1(int[] array, int sum) // формирование строки вывода
{
    string result = $"Сгенерировался массив чисел: {Environment.NewLine}"
                  + $"[ {String.Join("; ", array)} ] {Environment.NewLine}"
                  + $"Сумма элементов на нечётных позициях = {sum}";
    return result;
}

int[] numbers = CreateArray1(10);
int sum = SumNotEven(numbers);
Console.Clear();
System.Console.WriteLine(Answer1(numbers, sum));
*/


//=====================================================================
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//                    [1 2 3 4 5] -> 5 8 3
//                    [6 7 3 6] -> 36 21
/*
int[] SumCouple(int[] array)
{
    int j = array.Length - 1;
    int[] result = new int[(int)Math.Round((double)array.Length / 2, MidpointRounding.ToPositiveInfinity)];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = (i == j) ? array[i] : array[i] + array[j];
        j--;
    }
    return result;
}

string Answer3(int[] array, int[] sum) // формирование строки вывода
{
    string result = $"Сгенерировался массив чисел: {Environment.NewLine}"
                  + $"[ {String.Join("; ", array)} ] {Environment.NewLine}"
                  + $"Суммы противоположных элементов: {Environment.NewLine}"
                  + $"[ {String.Join("; ", sum)} ]";
    return result;
}

int[] numbers = CreateArray1(5); // тут использовал функцию из задачки выше чтобы не плодить копипаст
int[] sum = SumCouple(numbers);
Console.Clear();
System.Console.WriteLine(Answer3(numbers, sum));
*/
