// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int num)
{
    if (num == 0) return;
    if (num > 1)
    {
    Console.Write($"{num}, ");
    NaturalNumbers(num - 1);
    }
    else Console.Write($"{num}");
}

NaturalNumbers(numberN);