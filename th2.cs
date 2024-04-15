int[] arr = { 5, 2, 4, 1, 3 };
int index = TimIndexSoNhoNhat(arr);
Console.WriteLine("Chỉ mục của số nhỏ nhất: " + index);

int TimIndexSoNhoNhat(int[] arr)
{
    int index = 0;
    int min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            index = i;
        }
    }

    return index;
}
