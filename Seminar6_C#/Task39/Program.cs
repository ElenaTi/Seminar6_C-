/* Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int[] generateArray(int length, int deviation)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}
void printArray(int[] arrayToPrint)
{
    Console.Write("[");
     for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length -1 )
        {
             Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int[] reverseArray(int[] arrayToReverse)
{
    int length = arrayToReverse.Length;
    int[] reversedArray = new int[length];
    for (var i = 0; i < length; i++)
    {
        reversedArray[i] = arrayToReverse[length - i - 1]; 
    }
    return reversedArray;
}

int[] sourceArray = generateArray(10,20);
int[] reversedArray = reverseArray(sourceArray);
printArray(sourceArray);
printArray(reversedArray);