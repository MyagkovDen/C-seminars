// 1. Получить строку, содержащую число
Console.Write("Введите целое число и нажмите Enter: ");
string userInput = Console.ReadLine() ?? ""; // ?? "" - защита от null

// 2. Преобразовать строку в число
int number = int.Parse(userInput); //  Помним об ошибках и исключениях

// 3. озводим число в квадрат
int result = number * number; 

// 4. Выводим результат в консоль
Console.WriteLine($"{number} -> {result}"); // интерполяция строк.