// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!)!;
int A1 = (number / 1000)%10;
int A2 = (number / 10)%10;
int B1 = number /10000;
int B2 = number % 10;
if(number>99999 || number < 10000)
{
    Console.WriteLine("Число не пятизначное");
}
else if(A1 == A2 && B1 == B2)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}

