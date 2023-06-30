/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
 6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите день недели цифрой: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 > 7)
{
   Console.WriteLine("дня не существует"); 
}
else if (number1 > 5 )
{
    Console.WriteLine("да");
}
else 
Console.WriteLine("нет");