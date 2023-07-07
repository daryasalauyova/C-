/*
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
 
 Console.WriteLine("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Total = numberA;

int count = 2;
Console.Write($"Number {numberA} in multiple times of {numberB} is: ");
while (count <= numberB)
{
    Total = Total * numberA;
    count++; //count = count + 1
}
Console.Write(Total + " ");