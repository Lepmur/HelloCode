bool IsPalindrome(int x) 
{
    string array = Convert.ToString(x); // конвертируем число в строку, чтобы можно было сравнивать каждый символ отдельно
    int i = 0;
    int j = array.Length - 1;
    while (i < j) // шагаем по "массиву"(слову) смотря на первый и последний символ, пока они не сблизились
    {
        if (array[i] != array[j]) // если они разные
            return false; // возвращаем false
        i++; // иначе берем следующую пару
        j--;
    }
       return true; // элементы сблизились и мы не вылетели в false - число палиндром!
}

int number = 15951; // пример - сравнили 1 и 1, сравнили 5 и 5, 9 не сравниваем т к сблизились, в false не вылетели - палиндром
System.Console.WriteLine(IsPalindrome(number));
