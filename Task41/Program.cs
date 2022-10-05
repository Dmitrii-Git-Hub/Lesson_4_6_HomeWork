// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void CountNumbersGreater0(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { count++; }
    }
    Console.WriteLine($"Количество чисел больше 0: {count}");
}

Console.WriteLine("Сколько будет чисел?");
int M = Convert.ToInt32(Console.ReadLine());

CountNumbersGreater0((FillArray(M)));