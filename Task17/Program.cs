// Задача 17. Напишите программу, которая принимает на вход координаты точки
// х и у, причем Х не равно 0 и не равно 0 и выдает номер четверти плоскости,
// в которой находится эта точка.
  
Console.Clear();
Console.Write("Введите Х: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y >0)
{
    Console.WriteLine("I");
}
if(X < 0 && Y >0)
{
    Console.WriteLine("II");
}
if(X < 0 && Y < 0)
{
    Console.WriteLine("III");
}
if(X > 0 && Y < 0)
{
    Console.WriteLine("IV");
}