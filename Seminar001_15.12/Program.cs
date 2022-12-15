// Возведение в Квадрат

//Console.WriteLine("Введите число: ");
//int a = int.Parse(Console.ReadLine()!);
//int scr = a*a;                               // Математический метод
//int scr1 = Convert.ToInt32(Math.Pow(a, 2));  // Использование функции с конвертацией 
//Console.WriteLine($"Число {a} в квадрате является {scr} математически и {scr1} с использованием библиотеки");


//

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int b = -a;
while (b <= a) {
    Console.Write($"{b} ");
    b++;
}
