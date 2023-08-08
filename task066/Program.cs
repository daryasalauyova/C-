/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void RecursionNum(int M, int N, int sum)
    {
        if (M > N) 
        {
            return;
        }
        sum += M;
        Console.WriteLine("Sum of natural numbers from {0} to {1} is {2}", M, N, sum);
        RecursionNum(M+1, N, sum);
    }

 RecursionNum(1, 5, 0);