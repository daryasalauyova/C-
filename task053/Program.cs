﻿/*
Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
*/

int[,] Get2DArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void Replace(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array [0,i];
        array[0, i] = temp;
    }
}

int[,] arrayRnd = GetRandom2DArray(3, 4, 10);
Print2DArray(arrayRnd);
Console.WriteLine();
Replace(arrayRnd);
Print2DArray(arrayRnd);