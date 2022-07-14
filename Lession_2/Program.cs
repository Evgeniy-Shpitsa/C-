// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int second (int num)
{
    int x = num%100;
    return (x/10);
}
Console.Write(second(997));

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string weekend (int num)
{
    if (num == 6)
    {
        return "Выходной день";
    }
    else if (num == 7)
    {
        return "Выходной день";
    }
    else
    {
        return "Рабочий день";
    }
}
Console.Write(weekend(7));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("введите число ");
int b = Convert.ToInt32(Console.ReadLine());
if (b/100 == 0)
{
    Console.Write("Третьей цифры нет");
}
else if (b/100 > 0 && b/100 < 10)
{
    Console.Write("Третье число ");
    Console.Write(b%10);
}
else if (b/100 > 10 && b/100 < 100)
{
    int c = b/10;
    Console.Write("Третье число ");
    Console.Write(c%10);
}
else if (b/100 > 100 && b/100 < 1000)
{
    int c = b/100;
    Console.Write("Третье число ");
    Console.Write(c%10);
}
else if (b/100 > 1000 && b/100 < 10000)
{
    int c = b/1000;
    Console.Write("Третье число ");
    Console.Write(c%10);
}