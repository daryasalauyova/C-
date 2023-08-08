/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в 
каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] matrix;
int minSum = int.MaxValue;
int minIndex = -1;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        rowSum += matrix[i, j];
    }
    if (rowSum < minSum)
    {
        minSum = rowSum;
        minIndex = i;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов: ");
for (int j = 0; j < matrix.GetLength(1); j++)
{
    Console.Write(matrix[minIndex, j] + " ");
}

