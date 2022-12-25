// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
                                                        // Решение математическим способом
/*
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a > 9999) && (a < 100000)) {
    int a1 = a / 10000;
    int a2 = a % 10000 / 1000;
    int a3 = a % 1000 / 100 ;
    int a4 = a % 100 / 10;
    int a5 = a % 10;
    if ((a1 == a5) && (a2 == a4)) Console.WriteLine($"Число {a} является палиндромом!");
    else Console.WriteLine($"Число {a} не является палиндромом!");
} else Console.WriteLine("Число не пятизначное!");
*/
                                                        // Решение через работу со строкой
/*
Console.Write("Введите пятизначное число: ");
string number = (Console.ReadLine());
if (number.Length == 5) {                        // тут нужна проверка является ли каждый элемент массива числом, а не пробелом или знаком
    int[] array = new int[number.Length];
    for (int i = 0; i < number.Length; i++) array[i] = Convert.ToInt32(number[i]);
    if ((array[0] == array[4]) && (array[1] == array[3])) Console.WriteLine($"Число {number} является палиндромом!");
        else Console.WriteLine($"Число {number} не является палиндромом!");
} else Console.WriteLine("Число не пятизначное!");
*/

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
bool Check (string array)  // проверка правильности ввода
{
    if ((array.Length == 5) && (array[1] == ',') && (array[3] == ',') && (Char.IsNumber(array, 0)) && (Char.IsNumber(array, 2)) && (Char.IsNumber(array, 4))) 
    {
        return true;
    }
    else return false;
}
int[] convert (string array) // конвертация str[0,1,2,3,4] в int[0,1,2]
{
    int[] convArray = new int[3];
    convArray[0] = Convert.ToInt32($"{array[0]}");
    convArray[1] = Convert.ToInt32($"{array[2]}");
    convArray[2] = Convert.ToInt32($"{array[4]}");
    return convArray;
}
double distance (int[] array1, int[] array2) // вычисление дистанции точек a[x,y,z] и b[x,y,z]
{
    double result = Math.Round(Math.Sqrt(Math.Pow(array1[0]-array2[0],2) + Math.Pow(array1[1]-array2[1],2) + Math.Pow(array1[2]-array2[2],2)), 4);
    return result;
}
Console.Clear();
Console.Write($"Введите координаты точки А в формате X,Y,Z и нажмите Enter: ");
string tempA = Console.ReadLine()!;
if (Check(tempA) == false) // Проверка первого массива координат
{
    while (Check(tempA) == false) {
        Console.WriteLine("Вы ввели неверный формат");
        Console.Write($"Введите координаты первой точки в формате X,Y,Z и нажмите Enter: ");
        tempA = Console.ReadLine()!;
    }
}
Console.Clear();
Console.Write($"Введите координаты точки В в формате X,Y,Z и нажмите Enter: ");
string tempB = Console.ReadLine();
if (Check(tempB) == false) // Проверка второго массива координат
{
    while (Check(tempB) == false) {
        Console.WriteLine("Вы ввели неверный формат");
        Console.Write($"Введите координаты второй точки в формате X,Y,Z и нажмите Enter: ");
        tempB = Console.ReadLine()!;
    }
}
int[] crdntA = convert(tempA);  // необязательное конвертирование в более удобный числовой массив
int[] crdntB = convert(tempB);
Console.Clear();
System.Console.Write($"Расстояние между точкой А({tempA}) и точкой В({tempB}) равно {distance(crdntA, crdntB)}.");
*/

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
int[] tabQube (int n) // запись в массив таблицы кубов числа N
{
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = Convert.ToInt32(Math.Pow((i+1), 3));
    }
    return result;
}
void PrintArray (int[] array) // вывод массива в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] result = tabQube(n);
Console.Write($"Таблица кубов для числа {n} => ");
PrintArray(result);
*/
