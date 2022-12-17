int[] array = {14 ,22 ,31 ,44 ,53 ,64 ,73 ,84};
int n = array.Length;
int find = 44;
int index = 0;

while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}
