/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int index(int N)
{
    int Sum = 0; //количество цифр в числе

    while (N > 0)
    {
        Sum += N % 10;
        N /= 10; // N = N/10    
    }
    return Sum;
}

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе: " + index(A));