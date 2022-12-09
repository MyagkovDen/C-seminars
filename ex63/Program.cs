// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.Clear();

int n = GetNumberFromUser("Введите число", "Ошибка ввода!");
int start = 1;
string result = Numbers(start, n);
Console.WriteLine(result);

string Numbers(int start, int n)
{
    if (start == n) return start.ToString();
    return start + " " + Numbers(start + 1, n);
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