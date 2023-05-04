// Перевернуть элементы в массиве

void InputArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int x = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = x;
    }
}

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Reverse(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
