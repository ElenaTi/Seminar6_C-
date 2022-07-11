/* Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования. */

int[] generateArray(int length, int deviation)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}

int[] array = generateArray(4, 10);
int[] arrayCopy = new int[array.Length];
for (int i = 0; i < arrayCopy.Length; i++)
{
    arrayCopy[i] = array[i];
}
printArray(array);

printArray(arrayCopy);

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