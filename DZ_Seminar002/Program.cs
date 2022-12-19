// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.  Обязательна проверка на ввод чисел больше/меньше 3-х знаков
/*
Console.Write("Введите 3-значное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
if ((number > 100)&&(number < 1000)) {
    int result = number / 10 % 10;
    Console.WriteLine(result);
} else {
    Console.WriteLine($"Вы ввели {number}, оно 3-значное? А просили какое?");
}
*/

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
/*
Console.Write("Введите число от 100 до 100000: ");
int number = Convert.ToInt32(Console.ReadLine()!);
int result = 0;
if ((number < 100)||(number > 99999)) {
    if (number < 100) Console.WriteLine($"В числе {number} нет 3 цифры!");
    else Console.WriteLine($"Число {number} меньше 100000? Уверен? А если найду?");
} else {
    if (number < 1000) result = number % 10;
    if ((number > 999)&&(number < 10000)) result = number % 100 / 10;
    if (number > 9999) result = number % 1000 / 100;
    Console.WriteLine(result);
}
*/

// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.  Обязательна проверка на ввод числа <1 и >7
/*
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine()!);
if ((number < 1)||(number > 7)) Console.Write($"Это чё за день недели с номером {number}?");
else {
    if (number < 6) Console.Write($"Это будний день");
    else Console.Write($"Это выходной");
}
*/