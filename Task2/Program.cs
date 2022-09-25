int mas = 4;
int[,] a = new int[mas, mas];
FillArraySpiral(a, mas);
PrintArray(a);

void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int meaning = 1;

    for (int z = 0; z < n * n; z++)
    {
        int k = 0;
        do { array[i, j++] = meaning++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = meaning++;
        for (k = 0; k < n - 1; k++) array[i, j--] = meaning++;
        for (k = 0; k < n - 1; k++) array[i--, j] = meaning++;
        i++; j++;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
}
