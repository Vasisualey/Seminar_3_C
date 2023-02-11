﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Эльвира, следую четко по техническому заданию: если пользователь введет например число -3, то итерация
// должна идти с числами от 1 до -3 (1, 0, -1, -2, -3).Иначе в задаче должно фигурировать слово "неотрицательное"
// чтобы я провел проверку больше ли оно ноля.
// Поэтому, я делаю переключение направления счета от числа 1 в отрицательную или в положительную сторону с помощью "if...else".

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!)!;
int Counter = 1;
if(N>=1)
{
while(Counter <= N)
{
    Console.Write(Math.Pow(Counter,3)+" ");
    Counter = Counter + 1;
}
}
else
{
    while(Counter >= N)
{
    Console.Write(Math.Pow(Counter,3)+" ");
    Counter = Counter - 1;
}
}
