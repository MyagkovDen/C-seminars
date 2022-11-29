// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8 


Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Если N = {number} -> 0 1 ");

Fibonachi(number);

void Fibonachi(int num)
{
    int num1 = 0;
    int num2 = 1;
    int temp;
    for (int i = 0; i < number - 2; i++)
    {
        temp = num1 + num2;
        Console.Write($"{temp} ");

        num1 = num2;
        num2 = temp;
    }
}