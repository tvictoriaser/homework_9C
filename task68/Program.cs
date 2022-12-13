// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return AckermannFunction(M - 1, 1);
    else return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
}

if (numberM > 3 && numberN > 0) Console.WriteLine("Переполнение стека");
else
{
    int ackermannfunction = AckermannFunction(numberM, numberN);
    Console.WriteLine($"Для чисел ({numberM},{numberN}) функция Аккермана = {ackermannfunction}");
}