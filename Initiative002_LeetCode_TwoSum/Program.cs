int[] TwoSum(int[] nums, int target) // функция принимает на ввод массив и число. возвращает индексы элементов, сумма которых равна этому числу
{
    Dictionary<int, int> temp = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++) 
    {
        int j = target - nums[i];
        if (temp.ContainsKey(j)) 
        {
            return new int[] {temp[j], i};
        }
        else 
        {
            temp[nums[i]] = i;
        }
    }
    throw new Exception ("Not found!");
}

int[] a = new int[5];
TwoSum(a, 4);

/*
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i+1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) 
                {
                    return new int [] {i, j};
                }
            }
        }
        throw new Exception ("Not found!");
    }
}
*/