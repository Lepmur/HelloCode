// Вид 1
void Method1()
{
    System.Console.WriteLine("I am autor...");
}
// Method1();

// Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("Text message");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Hello, Andrey!",count: 5);

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
// int date = Method3();
// System.Console.WriteLine(date);

// Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result += text;
        i++;
    }
    return result;
}
// string res = Method4(10, "asdf");
// System.Console.WriteLine(res);

// Вывод таблицы умножения на кран
/*
for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i * j}");
    }
    System.Console.WriteLine();
}
*/

// ======= Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?
/*
string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result += newValue;
        else result += text[i];
    }
    return result;
}

string newText = Replace(text, ' ', '_');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);
*/



// ============= Работа с массивами
// Нужно отсортировать массив от мин к макс

int[] Sorted(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                temp = array[i];
                array[i] = array[j] ;
                array[j] = temp;
            }
        }
    }
    return array;
}

int[] array = {8, 1, 3, 2, 6, 4, 5, 7};   // заданный массив
int[] arraySort = Sorted(array);          // сортировка
for (int i = 0; i < arraySort.Length; i++)   // вывод массива на экран 
    Console.Write($"{arraySort[i]} ");
