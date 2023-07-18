//

int[] copyArray(int[] arr) 
{
    int[] copyArray = new int[arr. Length];
    for (int i = 0; i < arr.Length; i++)
        copyArray[i] = arr[i];
    return copyArray;
}

void printArr(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.WriteLine(arr[i] + "]");
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int [] test = {1, 2, 3, 4, 5, 6, 7};
printArr(test);
int [] testCopy = copyArray(test);
printArr(testCopy);
