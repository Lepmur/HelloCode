// запросить длину последовательности фибоначчи, записать ее в массив и вывести массив на экран

int[] genFibonacci(int size) // генерирует фибоначчу заданной длины, начиная с 1
{
    int[] array = new int[size];
    array[0] = 1;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
        array[i] = array[i - 1] + array[i - 2];
    return array;
}
/*
Console.Clear();
System.Console.Write("Please, enter sequence length: ");
int length = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"[ {String.Join("; ", genFibonacci(length))} ]");
*/

//==============================================================================================

// запросить у пользователя 10 чисел, можно прекратить введя 0. посчитать среднее от кратных 3 из этих чисел

double averageMultiples3(double[] array) // возвращает среднее арифметическое от кратных 3 элементов заданного массива
{
    double sum = 0;
    double count = 0;
    foreach (var item in array)
    {
        if (item % 3 == 0 && item != 0)
        {
            sum += item;
            count++;
        }
    }
    double result = sum / count;
    return result;
}

double[] readMassive() // возвращает массив длиной 10 из введенных чисел (остаток заполнен 0)
{
    double[] array = new double[10];
    int i = 0;
    while (i <= 9)
    {
        double number = double.Parse(Console.ReadLine()!);
        if (number != 0)
            array[i++] = number;
        else
            break;
    }
    return array;
    System.Console.WriteLine();
}
/*
Console.Clear();
System.Console.WriteLine("Please, enter up to 10 integers (for stop enter 0): ");
double[] numbers = readMassive();
System.Console.WriteLine($"Average of multiple of 3 = {averageMultiples3(numbers)}");
*/

//==============================================================================================

// запросить число и вывести его факториал (!n)

long factorial(int n) // вычисляет факториал от n
{
    long result = 1;
    while (n != 0)
        result *= n--;
    return result;
}
/*
Console.Clear();
System.Console.Write("Please, enter integer (n): ");
int number = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"{number}! = {factorial(number)}");
*/

//==============================================================================================

// запросить у пользователя логин и пароль (3 попытки) если верно то "Enter the system!"
// если не верно 3 раза то "The number of available tries have been exceeded!"

string ReadPassword(char mask) // считывает строку, скрывая символы заданной маской (честно СПИЗЖЕНО)
{
    const int ENTER = 13, BACKSP = 8, CTRLBACKSP = 127;
    int[] FILTERED = { 0, 27, 9, 10 /*, 32 space, if you care */ }; // const
    var pass = new Stack<char>();
    char chr = (char)0;
    while ((chr = System.Console.ReadKey(true).KeyChar) != ENTER)
    {
        if (chr == BACKSP)
        {
            if (pass.Count > 0)
            {
                System.Console.Write("\b \b");
                pass.Pop();
            }
       }
        else if (chr == CTRLBACKSP)
        {
            while (pass.Count > 0)
            {
                System.Console.Write("\b \b");
                pass.Pop();
            }
        }
        else if (FILTERED.Count(x => chr == x) > 0) { }
        else
        {
            pass.Push((char)chr);
            System.Console.Write(mask);
        }
    }
    System.Console.WriteLine();
    return new string(pass.Reverse().ToArray());
}

bool Access(string log, string pass) // возвращает false или true в зависимости от совпадения
{
    int count = 0;
    while (count < 3)
    {
        Console.Clear();
        System.Console.Write("Please enter your login: ");
        string loginByUser = Console.ReadLine();
        System.Console.Write("Please enter your password: ");
        string passByUser = ReadPassword('*');
        if (loginByUser == log && passByUser == pass)
            return true;
        else
            count++;
    }
    return false;
}
/*
Console.Clear();
string allowed = "Enter the system!";
string denied = "The number of available tries have been exceeded!";
if (Access("johnsilver", "qwerty"))
    System.Console.WriteLine(allowed);
else
    System.Console.WriteLine(denied);
*/
