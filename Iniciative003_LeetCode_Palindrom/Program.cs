/*
bool IsPalindrome(int x) 
{
    string array = Convert.ToString(x);
    int length = array.Length;
    for (int i = 0, j = (length - 1); i < ((length / 2) - 1); i++)
    {
        if (Convert.ToInt32(array[i]) == Convert.ToInt32(array[j])) return true;
        else break;
    }
    return false;
}
*/
int x = 122;
string array = Convert.ToString(x);
        int length = array.Length;
        int a;
        for (int i = 0, j = (length - 1); i < (length / 2); i++, j--)
        {
            if ((array[i]) == array[j]) a = 1;
            else a = 2;
            System.Console.WriteLine(a);
        }


