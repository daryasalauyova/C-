﻿/*
Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.WriteLine("Введите количетво: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите число; ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < M; i++)
{
    int count = 0;
    if (array[i] > 0)
    {
        count+=1;
    }
}
Console.WriteLine($"Колличество положительных чисел:{count}");