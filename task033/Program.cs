/*
Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.WriteLine("]");
    Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Введите число ");
int Num = Convert.ToInt32(Console.ReadLine());

int [] randomArray = getRandomArray(5, 9);

int[] getRandomArray(int v1, int v2)
{
    throw new NotImplementedException();
}

printArray(randomArray);

void printArray(int[] randomArray)
{
    throw new NotImplementedException();
}

bool isNumberInArray(int [] randomArray, int Number)
{
    for(int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] == Number)
        return true; 
    }
    return false;
}
if (isNumberInArray(randomArray,Num))
Console.WriteLine("Да");
else Console.WriteLine("Нет");