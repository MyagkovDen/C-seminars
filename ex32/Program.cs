Console.Clear();

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

ChangeNumber(array);
Console.WriteLine(String.Join(" ", array));



//////////////////////////////////////////////////////////////////////////////////

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

// Заменяет положительные элементы массива на отрицательные, и наоборот

void ChangeNumber(int[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = arr[index] * (-1);
    }
}


