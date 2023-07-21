/*
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1.
*/

void NatureleNum (int Number, int count = 1)
{
    if (Number < count)
    return; 
    else
    {
        Console.Write(count+" " );
        NatureleNum(Number, count+1);
    }
}
NatureleNum(5);