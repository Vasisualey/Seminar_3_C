// Напишите программу, которая по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти
Console.Clear();
Console.Write("Введите Номер четверти: ");
int quarter = int.Parse(Console.ReadLine()!)!;
if (quarter > 4 || quarter < 1)
{
    Console.WriteLine("Нет такой четверти в системе координат!!!");  
}
else if(quarter==1)
    {
        Console.WriteLine("В первой четверти x > 0 и y > 0");
    }
else if(quarter==2)
    {
        Console.WriteLine("Во второй четверти x < 0 и y > 0");
    }
else if(quarter==3)
    {
        Console.WriteLine("В третьей четверти x < 0 и y < 0");
    }
else
    {
        Console.WriteLine("В четвертой четверти x > 0 и y < 0");
    }