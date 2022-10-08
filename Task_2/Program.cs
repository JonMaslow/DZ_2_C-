/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void GetNumber()
{
    string number = Console.ReadLine()??"";
    int temp = -100;
    if (int.Parse(number) < 100 && int.Parse(number) > temp)
    {   
        Console.WriteLine($"В веденном числе {number} нет третей цифры");
        return;
    }
    else
    {
        if (int.Parse(number) < -100)
        {
            string digit = number.ToString();
            int result = int.Parse(digit[3].ToString());
            Console.WriteLine($"Третей цифрой числа {number} является {result}");
        }
        else
        {
            string digit = number.ToString();
            int result = int.Parse(digit[2].ToString());
            Console.WriteLine($"Третей цифрой числа {number} является {result}");
        }
    }
}
GetNumber();
