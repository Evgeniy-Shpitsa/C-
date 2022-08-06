// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = a;
for (int i = 1; i<b; i++)
    {
        sum = sum * a;
    }
Console.WriteLine(sum);

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int size = x.ToString().Length;
int summ = 0;
for (int i = 0; i < size; i++)
    {
    summ = summ + (x % 10);
    x = x / 10;
    }
Console.WriteLine(summ);