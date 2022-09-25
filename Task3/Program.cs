Console.WriteLine("Введите неотицательное число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите неотрицательное N: ");
int numberN = int.Parse(Console.ReadLine());

int AckermannFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
return AckermannFunction(numM, numN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");