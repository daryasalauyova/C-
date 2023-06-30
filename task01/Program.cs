/*
Напишите программу, которая на входе принимает два числа и проверяет, 
является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2; b = 10-> нет
a = 9; b = -3 -> да
a = -3; b = 9 -> нет
*/

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
bool result;

if (number1 == number2 * number2) result = true;
else result = false;

Console.WriteLine(result);
