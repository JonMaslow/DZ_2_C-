/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

void WeekendSearch()
{
    Console.WriteLine("Введите день недели от 1 до 7:");
    int day = int.Parse(Console.ReadLine()??"");
        if (day == 6)
        {
            Console.WriteLine("Сегодня субботу, можешь отдыхать и весилиться ;-)");
            return;
        }
        if (day == 7)
        {
            Console.WriteLine("Сегодня воскресенье, отсыпайся завтра на РАБоту :-(((");
            return;
        }
         if (day >= 1 && day < 6)
         {
            Console.WriteLine("Сегодня не выходной, так что собирись и РАБотай !!!");
            return;
        }
        else
        {
            Console.WriteLine("Вы ввели не корректное значение, необходимо ввести число от 1 до 7.");
            return;
        }
}

WeekendSearch();