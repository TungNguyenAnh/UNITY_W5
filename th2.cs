int[] mangSo = { 5, 2, 4, 1, 3 };
int viTriSoNhoNhat = TimIndexSoNhoNhat(mangSo);
Console.WriteLine("Chỉ mục của số nhỏ nhất: " + viTriSoNhoNhat);

int TimIndexSoNhoNhat(int[] mangSo)
{
    int viTriSoNhoNhat = 0;
    int soNhoNhat = mangSo[0];

    for (int i = 1; i < mangSo.Length; i++)
    {
        if (mangSo[i] < soNhoNhat)
        {
            soNhoNhat = mangSo[i];
            viTriSoNhoNhat = i;
        }
    }

    return viTriSoNhoNhat;
}
