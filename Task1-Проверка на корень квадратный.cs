//  Задача 1: Проверка на корень квадратный

Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m * m == n)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");