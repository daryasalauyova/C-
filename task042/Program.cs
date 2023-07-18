/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное
*/

System. Console.WriteLine ("Введите число:");
int value = Convert.ToInt32(Console.ReadLine()); 

int binary = 0;
int shift = 0;
while (value != 0)
{
    binary += value % 2;
    shift *= 10; 
    value /= 10;
}
Console.Write(binary);

/*
    double DecimalToBinary (int dec)
{
    double bin = 0;
    int count = 0;
    while (dec > 0)
    {
        bin += dec % 2 * Math.Pow(10, count);
        dec /= 2;
        count++;
        }
    return bin;
}
System.Console.WriteLine(DecimalToBinary(123));
*/