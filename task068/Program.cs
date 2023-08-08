/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение m: ");
        string inputM = Console.ReadLine();
        Console.Write("Введите значение n: ");
        string inputN = Console.ReadLine();
        int m, n;

        if (int.TryParse(inputM, out m) && int.TryParse(inputN, out n))
        {
            int result = Ackermann(m, n);
            Console.WriteLine($"A({m}, {n}) = {result}");
        }
    }
}
