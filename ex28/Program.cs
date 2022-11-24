int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!");
int prodNumbers = GetProdNumbers(A);
Console.WriteLine($"{A} -> {prodNumbers}");





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

int GetProdNumbers(int number)
{
    int prod = 1;
    while(number > 0)
{
    prod *= number;
    number--;
}

// for(int i = 1; i <= number; i++)
// prod *= i;



return prod;
}