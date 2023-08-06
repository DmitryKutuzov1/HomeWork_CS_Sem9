// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int start, int finish)
{
    if (finish == start) return start;
    return finish + SumNumbers(start, finish - 1);
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetImput("Введите первое число: ");
int n = GetImput("Введите второе число: ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {SumNumbers(m, n)}");