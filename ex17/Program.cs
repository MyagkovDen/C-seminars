Console.Clear();
int X, Y;

try
{
    Console.Write("Введите X: ");
    X = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите Y: ");
    Y = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

if (X > 0 && Y > 0)             // лучше не перемешивать логику и выводы. Например, внести переменную int a
    Console.WriteLine("1");     // int a = 1;
else if (X < 0 && Y > 0)
    Console.WriteLine("2");     // int a = 2;
else if (X < 0 && Y < 0)
    Console.WriteLine("3");     // int a = 3;
else if (X > 0 && Y < 0)
    Console.WriteLine("4");     // int a = 4;
else
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");  // int a = -1;