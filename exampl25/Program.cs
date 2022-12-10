/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int degree(int X, int Y)
{
int rezult = 1;
for (int i = 0; i < Y; i++)
{
    rezult = rezult * X;
}
return rezult;
}

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B , в которую возвести А: ");
int B = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Результат возведения в степень числа А в степень В: ");
Console.WriteLine( degree(A, B));
