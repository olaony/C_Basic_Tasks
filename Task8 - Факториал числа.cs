// Задача: найти факториал числа 
// (произведение всех чисел от 1 до n)

int n = Convert.ToInt32(Console.ReadLine());
int res = 1;
int i = 1;
while (i <= n)
{
    res *= i; 
    // res = res * i;
    // res = 1* 2;
    // res = 2 * 3;
    i++;
}
Console.WriteLine(res);

// 2 способ
// int n = Convert.ToInt32(Console.ReadLine());
// int f = 1;

// for (int i = 1; i <= n; i++)
// {
// f = f * i; 
// }
// Console.WriteLine(f);
