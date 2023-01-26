// ================================ Двумерные массивы ===============================================
/*
int[,] doubleArray = { { 1, 2, 3}, { 4, 5, 6 } };      // 1 2 3
int[,] doubleArray1 = new int[ 2, 3 ];                 // 4 5 6
// n[0,0] n[0,1] n[0,2]                0 0 0    2 rows
// n[1,0] n[1,1] n[2,2]                0 0 0    3 cols

int[,] CreateArray(int rows, int cols, int from, int to) // генерирует массив rows*cols и заполняет рандомом from to
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array) // выводит двумерный массив в виде матрицы
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateArray(5, 6, 1, 9);
PrintArray(array);
*/
//===================================================================================================


// Собрать строку с числами от a до b, a <= b
/*
string NumbersFor(int a, int b) // обычной метод for
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

string NumbersRec(int a, int b) // рекурсия
{
    if (a <= b) return $"{a}" + NumbersRec(a + 1,b);
    else return String.Empty;
}

Console.Clear();
System.Console.WriteLine("Строка for " + NumbersFor(1, 5));
System.Console.WriteLine("Строка рекурсией " + NumbersRec(1, 5));
*/
//========================================================================

// Факториал числа
/*
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *=i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.Clear();
System.Console.WriteLine("For " + FactorialFor(10));
System.Console.WriteLine("Рекурсией " + FactorialRec(10));
*/
//======================================================================

// Вычислить a в степени n
/*
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{   
    return n == 0 ? 1 : PowerFor(a, n - 1) * a; // тернарный оператор
}

int PowerRecMath(int a, int n)
{
    if (n ==0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.Clear();
System.Console.WriteLine("For " + PowerFor(2, 10));
System.Console.WriteLine("Рекурсией " + PowerRec(2, 10));
System.Console.WriteLine("Рекурсией математически " + PowerRecMath(2, 10));
*/
//======================================================================

//Есть алфавит из букв "а", "и", "с", "в" Покажите все слова
//состоящие из T букв, которые можно построить из алфавита
/*
string ConvertToAnotherNumberSystem(int value, int foundation)
{
    string result = String.Empty;
    int numPrivate = value;
    if (value == 0) return "0";
    while (numPrivate != 0)
    {
        result = result.Insert(0, $"{numPrivate % foundation}");
        numPrivate = numPrivate / foundation;
    }
    return result;
}

void WordGen(string chars, int t)
{
    int numberOfWords = (int)Math.Pow(chars.Length, t);
    var charKeys = new Dictionary<int, char>();
    for (int i = 0; i < chars.Length; i++) 
        charKeys.Add(i, chars[i]);
    string wordResult = String.Empty;
    for (int i = numberOfWords; i < numberOfWords*2; i++) // чтобы учитывались 01 001 0001 00001 и т.д.
    {
        string word = ConvertToAnotherNumberSystem(i, chars.Length);
        word = word.Remove(0,1);
        for (int j = 0; j < word.Length; j++)
            wordResult += charKeys[Convert.ToInt32(Convert.ToString(word[j]))]; // тут хз как красивее конвертировать
        System.Console.WriteLine(wordResult);
        wordResult = "";
    }
}

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
        
}

Console.Clear();
WordGen("qwertyuio", 8); // работает при 1 < chars.Length < 11
//FindWords("аисв", new char[5]);
*/
//===========================================================================

// просмотр директорий рекурсией
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
}
CatalogInfo("D:\\Учёба\\GeekBrains");
*/
//==============================================================================

//ханойские башни
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
{
    if (count > 1) Towers(with, some, on, count - 1);
    System.Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();
*/
