// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
Console.WriteLine("Введите длину массива ");
int size = Convert.ToInt32(Console.ReadLine());
int [] massive = new int [size];
int sum = 0;
 for (int i=0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(100,999);
        if (massive[i] % 2 == 0)
        {
            sum = sum + 1;
        }               
    }

void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
PrintArray(massive);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел - {sum} ");

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите длину массива ");
int size = Convert.ToInt32(Console.ReadLine());
int [] massive = new int [size];
int sum = 0;
 for (int i=0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(1,10);
        if (i % 2 == 0)
        {
            sum = sum + massive[i];
        }               
    }
void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
PrintArray(massive);
Console.WriteLine();
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна - {sum} ");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите длину массива ");
int size = Convert.ToInt32(Console.ReadLine());
int [] massive = new int [size];
int max = 0;
int min = 10;
 for (int i=0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(0,10);
        if (massive[i] < min)
        {
            min = massive[i];
        }
        else if (massive[i] > max)
        {
            max = massive[i];
        }
    }
void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }
PrintArray(massive);
Console.WriteLine();
Console.WriteLine(max - min);