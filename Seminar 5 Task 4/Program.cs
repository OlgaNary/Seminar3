// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] arr = GetRandomArray(123);
PrintArray(arr);
System.Console.WriteLine(FindNumInInterval(arr));

//Метод подсчета количества элементов массива, значения которых лежат в отрезке [10,99]
int FindNumInInterval(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

// Метод создаем рандомный массив из 12 элементов:
int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 1; i < length; i++)
    {
        result[i] = new Random().Next(-9, 101);
    }
    return result;
}

// Метод выводит на печать заданный массив:
void PrintArray(int[] arr)
{
    System.Console.Write("Вы ввели массив: ");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    System.Console.WriteLine();
}