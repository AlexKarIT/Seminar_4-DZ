/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] GetArray(int N, int M)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, M + 1);
    }

    return array;
}


int L = 8;

Console.WriteLine("Введите максимальное значение, которое может принять каждый элемент:");
int max = Convert.ToInt32(Console.ReadLine());

var str = string.Join(", ", GetArray(L, max));
Console.WriteLine("Полученный массив из " + L + " случайных чисел от 1 до " + max + " (включительно): ");
Console.WriteLine("[" + str + "]");