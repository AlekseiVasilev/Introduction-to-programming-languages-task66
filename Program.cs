// Задача 66:
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("\t Задача №66");
Console.WriteLine("Введите число M");
int m = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));
Console.WriteLine("Введите число N");
int n = Math.Abs(int.Parse(Console.ReadLine() ?? string.Empty));

// Если мы хотим получить вывод суммы строго между m и n нужно скорректировать:
// return 0; и Console.WriteLine(Sum(m, n)-m);


Console.WriteLine(Sum(m, n));
int Sum(int a, int b)  
{
    if (a == b)
    {
        // Console.WriteLine($"{a}");
        return a;
    }
    else
    {
        // Console.WriteLine($"{a}");
        return a+Sum(a+1, b);
    }
}
