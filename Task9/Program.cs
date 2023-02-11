// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в два де пространстве

Console.Clear();
Console.Write("Введите Координату X1: ");
int X1 = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите Координату X2: ");
int X2 = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите Координату Y1: ");
int Y1 = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите Координату Y1: ");
int Y2 = int.Parse(Console.ReadLine()!)!;

double result = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2));
Console.WriteLine("Расстояние между двумя точками равно " + result);
