/*
Напишите программу, 
которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random() . Next (100, 1000);
Console.Write($" Случайное число - (randomNumber) без второй цифры");

int numberOne = randomNumber / 100;
int numberTwo = randomNumber % 100;
int newnumber = numberOne * 10 + numberTwo;
Console.WriteLine(newnumber);
