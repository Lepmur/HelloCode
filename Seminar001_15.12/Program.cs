// Возведение в Квадрат
/*
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int scr = a*a;                               // Математический метод
int scr1 = Convert.ToInt32(Math.Pow(a, 2));  // Использование функции с конвертацией 
Console.WriteLine($"Число {a} в квадрате является {scr} математически и {scr1} с использованием библиотеки");
*/

// Вывод ряда целых чисел от -n до n
/*
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int b = -a;
while (b <= a) {
    Console.Write($"{b} ");
    b++;
}
*/


// 1задача:

/*
Console.WriteLine("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (Math.Pow(number2, 2) == number1 ) {
    Console.WriteLine ($"Число {number1} является квадратом числа {number2} ");
    }
    else {
    Console.WriteLine ($"Число {number1} не является квадратом числа {number2} ");
    }
*/

// 2 задача:

/*
Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
if (num == 1) Console.WriteLine ($"Для числа {num} соотвествует день недели Понедельник");
if (num == 2) Console.WriteLine ($"Для числа {num} соотвествует день недели Вторник");
if (num == 3) Console.WriteLine ($"Для числа {num} соотвествует день недели Среда");
if (num == 4) Console.WriteLine ($"Для числа {num} соотвествует день недели Четверг");
if (num == 5) Console.WriteLine ($"Для числа {num} соотвествует день недели Пятница");
if (num == 6) Console.WriteLine ($"Для числа {num} соотвествует день недели Суббота");
if (num == 7) Console.WriteLine ($"Для числа {num} соотвествует день недели Воскресенье");*/

// 3 задача: 

/*
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Последнее число числа {num} является { num % 10}");
*/
