// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] arr = GetRandomArray(12);
PrintArray(arr);
PrintArray(ReplaceNum(arr));

// Метод создаем рандомный массив из 12 элементов:
int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 1; i < length; i++)
    {
        result[i] = new Random().Next(-9, 9);
    }
    return result;
}

// Метод выводит на печать заданный массив:
void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

// Метод замены знака у элемента:
int[] ReplaceNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}