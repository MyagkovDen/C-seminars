// Напишите программу, которая на вход принимает два числа A и B, и возводит А в целую степень В с помощью рекурсии.

Console.Clear();

int A = GetNumberFromUser("Введите число", "Ошибка ввода!");
int B = GetNumberFromUser("Введите число", "Ошибка ввода!");
int power = Pow(A, B);
Console.WriteLine($"{A} в степени  {B} = {power}");

int Pow(int a, int b)
{
    if (B == 0) return 1;
    if (b == 1) return a;
    return a * Pow(a, b - 1);
}





int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        else
            Console.WriteLine(errorMessage);
    }
}