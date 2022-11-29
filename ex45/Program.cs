// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью 
// поэлементного копирования

int[] array = GetArray(6, 0, 10);
int[] arrayCopy = CopyArray(array);

Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", array));

///////////////////////////////////////////////////////////////////////////////////////////////////////

int[] CopyArray(int[] arr)
{
    int[] arrCopy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrCopy[i] = arr[i];
    }
    return arrCopy;
}





int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}