int SearchInsert(int[] nums, int target) // функция возвращает индекс TARGET, а если его нет в массиве то возвращает место где он мог бы быть
{
    for (int i = 0; i < nums.Length; i++) // шагаем по массиву
    {
        if (nums[i] == target || nums[i] > target) // если текущий элемент >= TARGET возвращаем текущий индекс
            return i;
    }
    return nums.Length; // если ничего не нашли, значи TARGET больше последнего элемента и его индекс на один больше индекса последнего элемента
}


int[] array = {1,3,5,6};

System.Console.WriteLine(SearchInsert(array, 8)); 


