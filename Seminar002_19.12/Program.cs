// из рандомного трехзначного числа удалить число из середины
/*
int number = new Random().Next(100, 1000);
int result = number / 100 * 10 + number % 10;
Console.WriteLine($"{number} -> {result}");
*/

// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
/*
int numb = new Random().Next(10, 100); // 34 
Console.WriteLine($"Выбранное число {numb}"); 
 
if(numb / 10 > numb % 10){ 
    Console.WriteLine($"максимальное  значение {numb / 10}"); 
} 
 Console.WriteLine($"максимальное значение {numb % 10}"); 
 */
 
//2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
/*
int nun_a = int.Parse(Console.ReadLine()!); 
int nun_b = int.Parse(Console.ReadLine()!); 
int result = nun_a % nun_b; 
Console.WriteLine($"результат: {result} = {nun_a} % {nun_b}"); 
if(nun_a % nun_b == 0){
    Console.WriteLine("Кратно"); 
}
else{
    Console.WriteLine($"{result}"); 
}
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
/*
Console.WriteLine("Введите число: "); 
int nun_C = int.Parse(Console.ReadLine()!); 
if(nun_C % 7 == 0 && nun_C % 23 == 0){ 
    Console.WriteLine($"Результат кратно"); 
} 
else{ 
    Console.WriteLine($"Результат не Кратен!"); 
} 
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 
/*
Console.WriteLine("Введите два числа: "); 
int number_A = int.Parse(Console.ReadLine()!); 
int number_B = int.Parse(Console.ReadLine()!); 
if(number_A * number_A == number_B || number_B * number_B == number_A){ 
    Console.WriteLine("Является"); 
} 
else{ 
    Console.WriteLine("НЕ является"); 
}
*/
