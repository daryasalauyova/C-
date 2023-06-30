/*
Напишите программу, 
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/ 

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num /100 == 0)

Console.WriteLine("Тетью число");
else
{
    while (num / 1000 != 0)
        num = num / 10;
    int thirdDigit = num % 10;
    Console.WriteLine(thirdDigit);
}
