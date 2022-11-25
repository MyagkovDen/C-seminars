// Задайте одномерный массив из 123 

Console.Clear();


int[] array = GetArray(123, 0, 199);
Console.WriteLine(String.Join(" ", array));

int count = CountNumber(array);
Console.WriteLine();

Console.WriteLine(count);



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


// Возвращает сумму положительных чисел массива arr


int CountNumber(int[] arr)
{
    int count = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] >= 10 && arr[index] <= 99)
            count += 1;
    }
return count;
}


