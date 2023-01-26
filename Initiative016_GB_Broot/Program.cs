//Есть алфавит из букв "а", "и", "с", "в" Покажите все слова
//состоящие из T букв, которые можно построить из алфавита

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

Console.Clear();
WordGen("аисв", 4); // работает при 1 < chars.Length < 11
