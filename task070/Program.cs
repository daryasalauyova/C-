/*Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел,
 для которых каждое следующее равно сумме двух предыдущих.
*/


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        string input1 = Console.ReadLine();
        Console.Write("Введите второе число: ");
        string input2 = Console.ReadLine();
        Console.Write("Введите количество чисел для вывода: ");
        string inputN = Console.ReadLine();
        int num1, num2, n;

        if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2) && int.TryParse(inputN, out n))
        {
            Console.Write($"{num1} {num2} ");
            for (int i = 2; i < n; i++)
            {
                int nextNum = num1 + num2;
                Console.Write($"{nextNum} ");
                num1 = num2;
                num2 = nextNum;
            }
        }
    }
}
