// Задача 3: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

Console.WriteLine("Input three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n >= 100 && n <= 999)
{
    n = n / 10;
}
Console.WriteLine(n % 10);
