/*
Напишите программу, которая на вхрд принимает при числа и проверяет, 
может ли существовать треуголник с сторонами такой длины 
*/

bool IsTrianglePossible(int sideA, int sideB, int sideC)
{
    if ((sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB))
        return true;
    return false;
}

if (IsTrianglePossible (1, 4, 5))
    System.Console.WriteLine("The triangle is possible. ");
else
    System.Console.WriteLine("The triangle is impossible. ");


