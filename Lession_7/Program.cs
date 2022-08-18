/*// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("введите количество строк");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n=Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m,n];

void PrintArrayRazm(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
         for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
           
        }
        Console.WriteLine();
    }
}

void FillArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble()*10;
        }
    }

}
FillArray(array);
PrintArrayRazm(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[m,n];

static void PrintArray(int[,] matr)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
      }
    }
static void FillArray(int[,] matr)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 10);
        }
      }
    }
static void searchnumber(int[,] matr)
    {
      Console.WriteLine("Введите искомое");
      int a = Convert.ToInt32(Console.ReadLine());  
      for (int i = 0; i < matr.GetLength(0); i++)
      {
       for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (a == matr[i,j])
            {
                Console.WriteLine($"индекс числа {a} - {i},{j}");
            }
        }
      }
    }
try
 {
    FillArray(array);
    PrintArray(array);
    searchnumber(array);
 }
 catch
 {
    Console.WriteLine("Это про индексы");
 }
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[m,n];

static void PrintArray(int[,] matr)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
      }
    }
static void FillArray(int[,] matr)
    {
      for (int i = 0; i < matr.GetLength(0); i++)
      {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 10);
        }
      }
    }
static void average(int[,] matr)
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
      {
        double averageSum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            averageSum += matr[i,j];
        }
        averageSum = (averageSum / matr.GetLength(0));
        Console.WriteLine($"средне арифмитическое столбца № {j+1} - {averageSum}");
      }
    }
FillArray (array);
Console.WriteLine("Заданный массив: ");
PrintArray(array);
Console.WriteLine("Средне арифмитическое число: ");
average(array);*/