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
string third (int num)
{
if (num/100 == 0)
{
    return "третьей цифры нет";
}
else
{
    string s = num.ToString();
    char[] sym = s.ToCharArray();
    string x = Convert.ToString(sym[2]);
    return x;
}
}
Console.Write(third(1289));