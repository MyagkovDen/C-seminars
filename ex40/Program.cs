// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник со сторонами такой длины.

Console.Clear();
Console.WriteLine("Введите длину стороны a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны c");
int c = Convert.ToInt32(Console.ReadLine());

if (IfTriangle(a, b, c))
    Console.WriteLine("Треугольник может существовать");
else
    Console.WriteLine("Треугольник не может существовать");

//////////////////////////////////////////////////////////////////////////////////////////////////

bool IfTriangle(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num3 + num1 && num3 < num1 + num2;
}