// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

Console.Clear();

int figure = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");

int dimensions = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int min = GetNumberFromUser("Введите значение минимального элемента массива: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите значение максимального элемента массива: ", "Ошибка ввода!");
int[] array = GetArray(dimensions, min, max);

Console.Write($"{figure}; массив [{String.Join(" ", array)}] -> ");

if (FindNumber(array, figure))
    Console.Write("да");
else
    Console.Write("нет");




//////////////////////////////////////////////////////////////////////////////////

// Получает число от пользователя

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

// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


bool FindNumber(int[] arr, int number)
{
    foreach (int el in arr)
    {
        if (el == number) return true;
        // else return false;
    }
    return false;
}




