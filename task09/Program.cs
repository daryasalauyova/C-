﻿/*
 Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
 показывает наибольшую цифру числа.
78 -> 8
1-> 2
85 -> 8
*/

int randomNumber = new Random() . Next (10, 100);
Console.WriteLine (rundomNumber);
int numberOne = rundomNumber % 10;
int numberTwo = rundomNumber / 10;
if (numberOne > numberTwo)
{
    Console.WriteLine(numberOne);
}
else
{
    Console.WriteLine(numberTwo);
}
