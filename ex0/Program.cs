// 1. Получить строку, содержащую число
Console.Write("Введите целое число и нажмите Enter: ");
string userInput = Console.ReadLine() ?? ""; // ?? "" - защита от null

// 2. Преобразовать строку в число
int number = 0;
try
{
    number = int.Parse(userInput); //  Помним об ошибках и исключениях
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка ввода! {ex.Message}");
    return;
}

// 3. Возводим число в квадрат
int result = number * number;

// 4. Выводим результат в консоль
Console.WriteLine($"{number} -> {result}"); // интерполяция строк.