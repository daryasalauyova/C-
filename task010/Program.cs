/*
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Ввелите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($" Случайное число - (randomNumber) без второй цифры");
int numberOne = num % 100;
int numberTwo = numberOne / 10;
Console.WriteLine($"{num}-->{numberTwo}");