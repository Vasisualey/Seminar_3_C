// Напишите программу которая принимает на вход  число N
// и выдает таблицу квадратов чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int X = int.Parse(Console.ReadLine()!)!;
int Counter = 1;
if(X>0)
{
while(Counter <= X)
{
    Console.Write(Math.Pow(Counter,2)+" ");
    Counter = Counter + 1;
}
}
else
{
    while(Counter >= X)
{
    Console.Write(Math.Pow(Counter,2)+" ");
    Counter = Counter - 1;
}
}
