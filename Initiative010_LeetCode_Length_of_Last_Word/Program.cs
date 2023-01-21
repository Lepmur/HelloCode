int LengthOfLastWord(string s) // функция возвращает длину последнего слова в заданной строке
{
    string result = s.ToLower();                      // присвоить переменной типа string копию заданной строки в нижнем регистре (не обязательно)
    result = result.Trim();                           // удалить все пробелы в конце и в начале строки
    string[] words = result.Split(' ');               // создать массив, поместить в каждый элемент массива по слову
    result = words[words.Length - 1];                 // присвоить переменной типа string последнее слово из массива
    return result.Length;                             // вернуть .Length от этой переменной string
}

string input = "luffy is still joyboy";               // например тут последнее слово joyboy
System.Console.WriteLine($"В последнем слове фразы \"{input}\" содержится {LengthOfLastWord(input)} букв.");    // функция вернет длину этого слова = 6
