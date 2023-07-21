/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix1 = {{1, 3, 6}, {1, 8, 6}};
int[,] matrix2 = {{7, 3}, {5, 14}, {10, 12}};
int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

Console.WriteLine("Результат умножения матриц:");
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}
