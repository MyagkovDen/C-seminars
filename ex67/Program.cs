// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Clear();

int n = GetNumberFromUser("Введите число", "Ошибка ввода!");
int sum = SumDigits(n);
Console.WriteLine($"{n} -> {sum}");

int SumDigits(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumDigits(n / 10);
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