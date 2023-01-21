/*
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/

/*
int[] array = GetArray(5, 0, 20);
Console.WriteLine($"[{String.Join(",", array)}]");
int[] resultArray = ReverseArray2(array);
Console.WriteLine($"[{String.Join(",", resultArray)}]");
ReverseArray1(array);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
        res[i] = new Random().Next(minValue, maxValue + 1);
    return res;
}

void ReverseArray1(int[] array){
    for(int i = 0; i < array.Length/2; i++){
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

int[] ReverseArray2(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[array.Length - i - 1];
    }
    return result;
}
*/



//Задача 40: Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема** каждая сторона треугольника меньше суммы двух других сторон.
/*
System.Console.Write("Enter side1: ");
int sideA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter side2: ");
int sideB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter side3: ");
int sideC = Convert.ToInt32(Console.ReadLine());

if (Check(sideA, sideB, sideC)) System.Console.WriteLine("This triangle is true");
else System.Console.WriteLine("This triangle is false");

bool Check(int a, int b, int c)
{
    if (a > 0 || b > 0 || c > 0)
    {
        if (a < b + c && b < a + c && c < a + b) return true;
        else return false;
    }
    else return false;
}
*/

//Определить, является ли заданное шестизначное число счастливым.
/*
System.Console.Write("Enter number: ");
string number = Console.ReadLine();
if (Check(number)) System.Console.WriteLine("This number`s happy");
else System.Console.WriteLine("This number`s not happy");

bool Check(string a)
{
    if (a.Length != 6) return false;
    else
    {
        if ((int)a[0] + (int)a[1] + (int)a[2] == (int)a[3] + (int)a[4] + (int)a[5]) return true;
        else return false;
    }
}
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1
/*
System.Console.Write("Enter size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"[ {String.Join(", ", createFibonacci(size))} ]");

int[] createFibonacci(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}
*/
