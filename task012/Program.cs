/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/
Console.WriteLine("Ввелите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int newNumber = 0;
if (num1 % num2 == 0) Console.WriteLine("Второе числа крастно первому");
else
{newNumber = num1 % num2;
Console.WriteLine($"Остаток от деления (newNumber)");
}