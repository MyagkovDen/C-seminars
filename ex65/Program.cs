// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();

int m = GetNumberFromUser("Введите число", "Ошибка ввода!");
int n = GetNumberFromUser("Введите число", "Ошибка ввода!");
int start = m;
string result = Numbers(start, n);
Console.WriteLine(result);

string Numbers(int start, int n)
{
    if (start < n)
    {
        if (start == n) return start.ToString();
        return start + " " + Numbers(start + 1, n);
    }
    else
    {
        if (start == n) return start.ToString();
        return start + " " + Numbers(start - 1, n);
    }
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