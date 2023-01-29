// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
//int[] arr = GetRandomArray(5);
//PrintArray(arr);
int[] newArray = FindSumOfPairs(new int[] { 6, 7, 3, 6});
PrintArray(newArray);

//Медод нахождения произведения пар чисел
int[] FindSumOfPairs(int[] array)
{
    int newSize = array.Length / 2;
    if (array.Length % 2 == 1)
    {
        newSize++;
    }
    int[] result = new int[newSize];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1)
    {
        result[newSize - 1] = array.Length / 2;
    }
    return result;
}

// Метод создаем рандомный массив из 12 элементов:
// int[] GetRandomArray(int length)
// {
//     int[] result = new int[length];
//     for (int i = 1; i < length; i++)
//     {
//         result[i] = new Random().Next(-9, 101);
//     }
//     return result;
// }

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