int[] PlusOne1(int[] digits)    // принимает на ввод массив цифр, возвращает массив, образующий число на 1 большее чем число из цифр массива на вводе
{
    string numberInString = "";                                // объявляем новую пустую строку
    for (int i = 0; i < digits.Length; i++)                    // идем по массиву
    {
        numberInString += Convert.ToString(digits[i]);         // наполняем строку цифрами из массива, преобразуя число в строку
    }
    double number = double.Parse(numberInString) + 1;          // присваиваем переменной double сформированнную строку преобразуя ее в число, прибавляем 1
    numberInString = Convert.ToString(number);                 // конвертируем число обратно в строку чтобы записать ее в массив
    int[] result = new int[numberInString.Length];             // объявляем новый массив, размером равным длине строки
    for (int i = 0; i < numberInString.Length; i++)            // идём по массиву
    {
        result[i] = Convert.ToInt32(Convert.ToString(numberInString[i]));  // наполняем массив цифрами из строки
    }
    return result;                                             // возвращаем массив
}
// эта функция будет работать только при числе в пределах типа double


int[] PlusOne(int[] digits)     // принимает на ввод массив цифр, возвращает массив, образующий число на 1 большее чем число из цифр массива на вводе
{
     int n = digits.Length;             
        for(int i = n-1; i >= 0; i--)        // шагаем по массиву с конца до начала
        {
            if(digits[i] < 9)                // если элемент меньше 9
            {
                digits[i]++;                 // прибавляем к нему 1
                return digits;               // и возвращаем результат. число сформировано
            }
            digits[i] = 0;                   // если элемент 9 присваиваем ему 0 и шагаем дальше
        }
        int[] newNumber = new int [n+1];     // если выше оказались все 9-ки
        newNumber[0] = 1;                    // создаем новый массив длиной больше предыдущего на 1 и присваиваем 0 элементу значение 1
        return newNumber;                    // остальные лементы по умолчанию аполняются нулями
}
// эта функция работает корректно с массивом любой длины


int[] array1 = {9,8,7,2,1,0};                                    // массив для примера 1 функции
int[] array = {9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9};         // массив для примера второй функции

array1 = PlusOne1(array1);
array = PlusOne(array);

Console.Clear();
System.Console.WriteLine("результат исполнения первой функции от массива array1:");
for (int i = 0; i < array1.Length; i++)
    Console.Write($"{array1[i]} ");

System.Console.WriteLine();
System.Console.WriteLine("результат исполнения второй функции от массива array:");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
