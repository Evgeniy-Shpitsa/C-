//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 14212 -> нет 12821 -> да 23432 -> да
Console.Write("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
string s = x.ToString();
char[] a = s.ToCharArray();
if (a[0]==a[4] && a[1]==a[3])
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите первую точку кординаты а: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую точку кординаты а: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью точку кординаты а: ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую точку кординаты b: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую точку кординаты b: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью точку кординаты b: ");
int b3 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow((b1-a1),2)+ Math.Pow((b2-a2),2)+ Math.Pow((b3-a3),2));
Console.Write(d);

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= c)
{
    Console.Write(Math.Pow(count,3));
    Console.Write(", ");
    count ++;
}