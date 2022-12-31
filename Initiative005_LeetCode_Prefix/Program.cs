string LongestCommonPrefix(string[] strs) {  // функция принимает на ввод массив слов и выводит их общий префикс, если его нет выводит null
        if (strs.Length == 0)  // что выводим если массив пустой
            return "";
        string result = strs[0];  // присваиваем результату первое слово, его и будем редактировать (урезать)
        for (int i = 0; i < strs.Length; i++) // шагаем по массиву пока не кончится
        {
            while ((strs[i].IndexOf(result) != 0)) // пока результат не станет префиксом strs[i] на позиции 0-го индекса самого слова
                result = result.Substring(0, result.Length - 1); // обрезаем результат на одну букву
        }
        return result;
    }

string[] array = {"flower","flow","flight"};
System.Console.WriteLine(LongestCommonPrefix(array));
