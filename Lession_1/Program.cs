// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("введите первое число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    Console.Write(x);
    Console.Write(" Большее число, а ");
    Console.Write(y);
    Console.Write(" меньшее число ");
}
else
{
    Console.Write(y);
    Console.Write(" Большее число, а ");
    Console.Write(x);
    Console.Write(" меньшее число ");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c)
    {
        Console.Write(a);
        Console.Write(" Наибольшее число");
    }
}
if (b > c)
{
    Console.Write(b);
    Console.Write(" Наибольшее число");
}
else
{
    Console.Write(c);
    Console.Write(" Наибольшее число");
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("введите число ");
int d = Convert.ToInt32(Console.ReadLine());
if (d%2 == 0)
{
    Console.Write("Четное число");
}
else 
{
    Console.Write("Нечетное число");
}
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число ");
int e = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= e)
{
    if (count%2 == 0)
    {
        Console.Write(count);
        count = count + 1;
    }
    else 
    {
        Console.Write(",");
        count = count + 1;
    }    
}