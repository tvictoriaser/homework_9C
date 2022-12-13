// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int m, int n)
{
    if (m > n) return m + SumNaturalNumbers(m - 1, n);
    else if (m < n) return m + SumNaturalNumbers(m + 1, n);
    else return m;
}

int sumNaturalNumbers = SumNaturalNumbers(numberM, numberN);
Console.WriteLine($"{sumNaturalNumbers}");