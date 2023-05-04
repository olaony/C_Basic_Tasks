// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

int[] array = {1, 5, 3, 8, 23, 6, 4};
int max = array[0];
int min = array[0];


for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Console.WriteLine("Разница между максимальным и минимальным элементом массива: [" + (max - min) + "]");
