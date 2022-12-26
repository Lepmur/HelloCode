int[] TwoSum(int[] nums, int target) // функция принимает на ввод массив и число. возвращает индексы элементов, сумма которых равна этому числу
{
    int[] ind = new int[2];
    for (int i1 = 0, i2 = 1; i1 < (nums.Length - 1) || i2 < (nums.Length - 1); i1++) 
    {
        if (nums[i1] + nums[i2] == target) 
        {
            ind[0] = i1;
            ind[1] = i2;
        } 
        else i2++;
    }
    return ind;
}
