// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string ShowNumbers(int number)
{
    if (number == 1) return number.ToString();
    return number + ", " + ShowNumbers(number - 1);
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetImput("Введите число: ");
Console.WriteLine(ShowNumbers(n));