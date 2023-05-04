//Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;

while (n > 0)
{
    summa = summa + n % 10;
    n = n / 10;
}

Console.WriteLine(summa);

