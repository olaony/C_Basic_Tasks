// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.


int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000);

int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count ++;
    }
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Console.WriteLine("Количество четных чисел: [" + count + "]");

        
