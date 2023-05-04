﻿// Напишите программу замена элементов массива: 
// положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}


int[] ChangeModule(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (-1) * array[i];
    }
    return array;
}

int[] arr = new int[12];
InputArray(arr);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + "]");
Console.WriteLine("Конечный массив данных: [" + string.Join(", ", ChangeModule(arr)) + "]");