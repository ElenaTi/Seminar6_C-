/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */


string GetBinary (int A)
{
    string result = String.Empty;
    while (A > 0)
    {
        int number2 = A % 2;
        A = A / 2; 
        result = number2 + result;     
    }
    return result;
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string number1 = GetBinary(number);
Console.WriteLine(number1);
