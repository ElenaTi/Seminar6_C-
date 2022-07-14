int[] array = new int[] { 3, 4, 5,85 };

array = array.Concat(new int[] { 10, 12 }).ToArray();
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
PrintArray(array);

