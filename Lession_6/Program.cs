// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i] > 0 ) count = count + 1;    
}
Console.WriteLine($"Введено чисел больше 0: {count} ");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double [,] arr = new double [2, 2];
double a =0;
double b = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write($"Введите значения для {i+1}-го уравнения ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if(j==0) Console.Write("Введите начение k: ");
      else Console.Write("Введите значение b: ");
      arr[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
if (arr[0,0] == arr[1,0]) Console.Write("Прямые параллельны");
else if (arr[0,1] == arr [1,1]) Console.Write("Прямые совпадают");
else
    {
    a = (arr[1,1] + (-1 * arr[0,1])) / (arr[0,0] + (-1 * arr[1,0]));
    b = (arr[0,0] * a + arr[0,1]);
    Console.Write($"Точка пересечения прямых: ({a};{b})");
    }