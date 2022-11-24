int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(A);
Console.WriteLine($"{A} -> {sumNumbers}");





//////////////////////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out int userNumber))
        return userNumber;

    else
    Console.WriteLine(errorMessage);

}
}

int GetSumNumbers(int number)
{
    int sum = 0;
    while(number > 0)
{
    sum += number;
    number--;
}
return sum;
}

