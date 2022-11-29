// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 - 10

int number = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");

int binaryNumber = ModToBinary(number);

Console.WriteLine($"{number} -> {binaryNumber}");

////////////////////////////////////////////////////////////////////////////////////////////////////////////

int ModToBinary(int num)
{
    int numeral = 0;
    for (int i = 0; num > 0; i++)
    {
        numeral += num % 2 * (int)Math.Pow(10, i);
        num /= 2;
    }
    return numeral;
}


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;

        else
            Console.WriteLine(errorMessage);
    }
}