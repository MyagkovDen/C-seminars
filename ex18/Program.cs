// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек
// в этой четверти (x и y)

Console.Clear();
int number, X, Y;

try
{
    Console.Write("Введите номер четверти: ");
    number = int.Parse(Console.ReadLine() ?? "");
}

catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

if (number == 1)
    Console.WriteLine("X > 0 && Y > 0");
else if (number == 2)
    Console.WriteLine("X < 0 && Y > 0");
else if (number == 3)
    Console.WriteLine("X < 0 && Y < 0");
else if (number == 4)
    Console.WriteLine("X > 0 && Y < 0");

Console.WriteLine("Ошибка ввода!");