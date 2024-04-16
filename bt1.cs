int[] arrays = { 10, 20, 30, 40, 50 };

System.Console.WriteLine("where to remove?:");
int index = int.Parse(Console.ReadLine());
int[] resultArrays = new int[arrays.Length - 1]; // Tạo mảng mới với kích thước nhỏ hơn 1

// Sao chép các phần tử sang mảng mới, bỏ qua phần tử tại vị trí được chọn
int j = 0;
for (int i = 0; i < arrays.Length; i++)
{
    if (i != index)
    {
        resultArrays[j] = arrays[i];
        j++;
    }
}

// Gán mảng mới cho mảng cũ
arrays = resultArrays;

// In mảng sau khi xóa
Console.WriteLine("Result Arrays:");
foreach (int number in arrays)
{
    Console.Write(number + " ");
}
