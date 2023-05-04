// Задайте одномерный массив из 123 
// случайных чисел. Найдите количество элементов 
// массива, значения которых лежат в отрезке [10,99]. 



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

int SearchNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        count ++;
    }
    return count;
}

int[] array = new int[123];
InputArray(array);

Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Console.WriteLine("Кол-во чисел в промежутке [10, 99]: " + SearchNumber(array));
