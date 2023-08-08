/*
Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

int[,] numbers = Get2DArray(5, 4);
PrintMatrix(numbers);

void PrintMatrix(int[,] numbers)
{
    throw new NotImplementedException();
}

Console.WriteLine($"Sum of dioganal ");