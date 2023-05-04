//Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Input five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n / 10000;
int b = (n / 1000) % 10;
int d = (n / 10) % 10;
int e = n % 10;

if (a == e && b == d)
Console.WriteLine("yes");
else
Console.WriteLine("no");
