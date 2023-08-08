/*
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1.
*/

void recCount(string[] args)
{
    Console.Write("Введите значение N: ");
    string input = Console.ReadLine();
    int N;

    if (int.TryParse(input, out N))
    {
        for (int i = N; i >= 1; i--)
        {
            Console.Write(i);
            if (i != 1)
            {
                Console.Write(", ");
            }
        }
    }
}
