void PrintArray(int[] col) //функция для вывода на печать массива, просто для проверки вывода
{
    int count = col.Length;
    int position = 0;
    while (position < count) 
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] TwoSum(int[] nums, int target) // принимает на ввод массив NUMS и число TARGET, возвращает массив из индексов 2-х элементов массива NUMS, сумма которых равняется TARGET
{
    int i = 0; // объявляем 2 счетчика
    int j = 1;
    int [] result = new int[2]; // объявляем массив для вывода результата
    while (i < nums.Length) // шагаем по массиву nums первым элементом
    {
        while (j < nums.Length) // шагаем по массиву nums вторым элементом
        {
            if (nums[i] + nums[j] == target) // если сумма текущих элементов равна target
            {
                result[0] = i; // присваиваем элементав массива с результатом номера индексов этих элементов
                result[1] = j;
                return result; // возвращаем массив с результатом
            }
            j++;
        }
        i++;
        j = i + 1; // не забываем "обнулить" позицию счетчика j
    }
    throw new Exception ("Not found!"); // на случай если сумма не найдена совсем
}

int [] nums = {4,33,9,12,64,23,6,3}; // для проверки, число 9 даст сумма элементов 6 и 3, из индексы [6,7]
int target = 9;
PrintArray(TwoSum(nums, target));
