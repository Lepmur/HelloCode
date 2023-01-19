//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
Console.Write("Введи число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма чисел от 1 до {A} равна {GetSum(A)}");
*/

//Приняять на вход число А и ввернуть произведение всех чисел от 1 до А 
 /*
Console.WriteLine ("Type a number "); 
int A = int.Parse(Console.ReadLine()!); 
Console.Write($"Factorial is equal {GetFactorial(A)}"); 
 */

// Напишите программу, которая принимает на вход число и выдает количество цифр в числе 
 /*
Console.WriteLine ("Type a number ");            // математически
int number = int.Parse(Console.ReadLine()!); 
Console.Write($"The number of digits is {GetQuantity(number)}"); 
 */
 /*
Console.WriteLine ("Type a number ");            // строкой
string Number = Console.ReadLine()!; 
Console.Write($"The number of digits is {GetQuantity2(Number)}"); 
 */
  
//Напишите программу, которая выводит массив из восьми элементов, 
//заполненный нулями и кдиницами в случайном порядке 
/*
int[] Array = GetArray(8); 
Console.Write($"[{String.Join(";", Array)}]"); 
 */



//--------------Методы-----------------
/*
int GetSum (int A) // сумма от 1 до А
{
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum = sum + i; // sum += i
    }
    return sum;
}

int GetFactorial (int A) // произведение от 1 до А
{ 
int Factorial = 1; 
for (int i = 1; i <= A; i++) 
{ 
    Factorial = Factorial * i; 
} 
return Factorial;
}

int GetQuantity (int A) // возвращает кол-во цифр в числе математически
{ 
    int Quantity = 0; 
    if (A == 0) return 1; 
    while (A > 0) 
    {Quantity = Quantity + 1; A = A / 10;} 
    return Quantity; 
}

int GetQuantity2 (string Number) // возвращает кол-во цифр в числе строкой
{ 
    int Quantity2 = Number.Length; 
    return Quantity2; 
}

int[] GetArray (int size) // возвращает бинарный массив заданной длины 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(2); 
    } 
    return Array; 
}
*/