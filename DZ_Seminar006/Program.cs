//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4
//Для строки можно использовать данный метод 
//string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
//(пользователь вводит в консоли числа через пробел и они формируют строку)
/*
System.Console.Write("Enter numbers (separated by spase): ");
string numbers = Console.ReadLine();
string[] numS = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
System.Console.WriteLine($"You entered {HowPositive(numS)} positive numbers!");
*/
int HowPositive(string[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (int.Parse(item) > 0) count++;
    }
    return count;
}


//===================================================================
//Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)
//в промежутке от 0 до 100, а на выходе выводит этот же массив, 
//но отсортированный по возрастанию(от меньшего числа к большему).
/*
int size = 0;
do
{
    System.Console.Write("Enter size > 5: ");
    size = Convert.ToInt32(Console.ReadLine());
} while(size < 6);

int[] array = CreateArray(size);
System.Console.WriteLine($"[ {String.Join(", ", array)} ]");
Sort(array);
System.Console.WriteLine($"[ {String.Join(", ", array)} ]");
*/
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
                
        }
    }
}
