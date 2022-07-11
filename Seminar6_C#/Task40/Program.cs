/* Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2 + number3 &&
    number2 < number1 + number3 &&
    number3 < number1 + number2)
{
    Console.WriteLine($"треугольник со сторонами {number1}, {number2}, {number3} может существовать");
}
else
{
    Console.WriteLine($"треугольник со сторонами {number1}, {number2}, {number3}  не может существовать");
}
