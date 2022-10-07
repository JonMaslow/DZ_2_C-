/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

void secondDigit(int result)
{
    if (result > 99 && result < 1000)
    {
        int secondDigit = result % 100 / 10;
        Console.Write($"В трехзначном числе {result} вторая цифра {secondDigit}");
    }
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число, попробуйте ещё раз");
        return;
    }
}
Console.WriteLine("Введите трёхзначное число: ");
secondDigit(int.Parse(Console.ReadLine() ?? ""));
