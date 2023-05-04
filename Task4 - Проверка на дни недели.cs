// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.WriteLine("Input figure from 1 till 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 5 && n > 0) 
        Console.WriteLine("no"); 
else if (n == 6 || n == 7)
    Console.WriteLine("yes");
else 
    Console.WriteLine("unknown");
    
