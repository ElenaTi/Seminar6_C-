/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  */

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

Console.WriteLine("Введите количество чисел, которое хотите ввести: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int [length];
for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length-1)
    {
        Console.WriteLine($"Введите последнее число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    else if (i == 0)
    {
        Console.WriteLine($"Введите первое число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
     else
    {
        Console.WriteLine($"Введите следующее число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountPositiveNumbers(int[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}
printArray(array);
int positiveNumbers = CountPositiveNumbers(array);
Console.WriteLine($"Было введено {positiveNumbers} положительных чисел");



 