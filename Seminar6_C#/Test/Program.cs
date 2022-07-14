Console.WriteLine("Введите числа через запятую.");
string? Numbers = Console.ReadLine();
Numbers = Numbers + ",";
int[] array = Array(Numbers);
PrintArray(array);
Console.WriteLine("");
int positiveNumbers = CountPositiveNumbers(array);
Console.WriteLine($"Было введено {positiveNumbers} положительных чисел");

int[] Array(string text)
{
    int[] array = new int[1];

    int index = 0;
    int col = 0;
    for (int i = 0; i < text.Length; i++)
    {
        string separateNumbers = String.Empty;

        while (text[i] != ',' && i < text.Length)
        {
            separateNumbers = separateNumbers + text[i];
            i++;
        }
        array[index] = Convert.ToInt32(separateNumbers);
        // Console.WriteLine(array[index]);
        if (i < text.Length - 1)
        {        
            array = array.Concat(new int[] { 0 }).ToArray();        
        } 
        index++;      
        // Console.WriteLine($"index = {index}");
    }
    return array;
}
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

int CountPositiveNumbers(int[] massive)
{
    int count =0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

