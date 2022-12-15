// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b) Console.WriteLine($"Число A ({a}) больше числа B ({b})");
else Console.WriteLine($"Число B ({b}) больше числа A ({a})");
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите число C: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"Число {max} наибольшее");
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0) Console.WriteLine($"Число {a} чётное");
else Console.WriteLine($"Число {a} нечётное");
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int a = 0;
Console.Write($"Все чётные числа от 1 до {n}: ");
while (a + 2 <= n) {                      //способов много, выбрал проще но интереснее, без if
    a += 2;
    Console.Write($"{a} ");
}
*/
