//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
/*
int[] array = GetArray(12,-9,9);
Console.WriteLine($"[{String.Join(",", array)}]");
int positiveSum = 0;
int negativeSum = 0;
foreach (int el in array)
{
    if(el > 0)
        positiveSum += el;
    else
        negativeSum += el;
}
Console.WriteLine($"Сумма положительных равна {positiveSum}, сумма отрицательных равна {negativeSum}");
*/
// ------Метод------
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


//=================== ЗАДАЧИ

//Напишите программу замены элементов массива:  
// положительные элементы замените на отрицательные 

int[] GetArray2 (int size)
{
    int[] Array = new int[size];
    for (int i =0; i < size; i++)
      Array[i] = new Random().Next(-10, 11);
    return Array; 
}
/*
int[] Array = GetArray2(10); 
Console.WriteLine($"[{String.Join(", ",Array)}]"); 
for (int i = 0; i < Array.Length; i++) 
{ 
    Array[i] = Array[i] * (-1); 
} 
Console.WriteLine($"[{String.Join(", ",Array)}]");
*/

//  Задайте массив и напишите программу,
// определяет, присутствует ли ли заданное число в массиве

int[] GetArray1 (int size)
{
    int[] Array = new int[size];
    for (int i =0; i < size; i++)
    {
      Array[i] = new Random().Next(-10, 11);
    }
    return Array;
}
/*
int[] Array = GetArray1(10); 
int Find = -5; 
Console.WriteLine($"[{String.Join(", ",Array)}]"); 
if (FindElement(Array, Find)) 
    Console.WriteLine($"Данный элемент найден"); 
else
    Console.WriteLine($"Данный элемент не найден");
*/
bool FindElement (int[] Array, int Find) 
{ 
    foreach (int ArrayEl in Array) 
    {
        if (ArrayEl == Find) 
            return true;
    }
    return false;
} 


// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] GetArray3 (int size) 
{ 
    int[] Array = new int[size];
    for (int i = 0; i < size; i++) 
      Array[i] = new Random().Next(0, 1001);   
    return Array; 
} 
/*
int[] Array = GetArray3(123);
Console.WriteLine($"[{String.Join(", ",Array)}]"); 
int count = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] >= 10 && Array[i] < 100) 
        count = count + 1; 
}
Console.WriteLine($"Количество цифр в данном диапазоне {count}");
*/
