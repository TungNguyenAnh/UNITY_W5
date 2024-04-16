string text = "hello world";

Console.WriteLine("Nhập chuỗi: ");
string type = Console.ReadLine();

int count = 0;

for (int i = 0; i < type.Length; i++)
{
    for (int j = 0; j < text.Length; j++)
    {
        if (type[i] == text[j])
        {
            count++;
            break;
        }
    }
}

Console.WriteLine("Số lần trùng khớp: {0}", count);
