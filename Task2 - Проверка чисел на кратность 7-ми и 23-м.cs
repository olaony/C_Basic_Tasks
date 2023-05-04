// Задача 2: Проверка чисел на кратность 7-ми и 23-м

int n = Convert.ToInt32(Console.ReadLine());
    if (n % 7 == 0  && n % 23 == 0)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");

