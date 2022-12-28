public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        int[] array = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I') array[i] = 1;
            if (s[i] == 'V') array[i] = 5;
            if (s[i] == 'X') array[i] = 10;
            if (s[i] == 'L') array[i] = 50;
            if (s[i] == 'C') array[i] = 100;
            if (s[i] == 'D') array[i] = 500;
            if (s[i] == 'M') array[i] = 1000;
        }
        int last = 0;
        for (int i = (array.Length - 1); i >= 0; i--)
        {
            if (array[i] < last) result -= array[i];
            else result += array[i];
            last = array[i];
        }
        return result;
    }
}