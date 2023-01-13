using System.Text;                      // для работы StringBuilder
string AddBinary(string a, string b)    // функция возвращает строковый результат сложения двух строк бинарных чисел
{
    var result = new StringBuilder();                          // объявим string builder
    int i = a.Length - 1, j = b.Length - 1, temp = 0;
    while (i >= 0 || j >= 0)                                   // пока хотябы одна из строк не кончилась идём с конца до начала
    {
        if (i >= 0)
            temp += Convert.ToInt32(a[i--].ToString());        // если строка a не кончилась прибавляем значение к temp
        if (j >= 0) 
            temp += Convert.ToInt32(b[j--].ToString());        // если строка b не кончилась прибавляем значение к temp
        result.Insert(0, temp % 2);                            // добавляем в начало строки с результатом остаток от деления на 2
        temp /= 2;                                             // записываем в temp результат целочисленного деления на 2
    }
    if (temp != 0) result.Insert(0, temp);                     // если строки кончились а в temp еще что то осталось, добавляем temp к началу строки с результатом
    return result.ToString();                                  // возвращаем строку результата с конвертацией в string
}

string number1 = "1010";
string number2 = "1111";
System.Console.WriteLine(AddBinary(number1, number2));
