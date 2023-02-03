// Задача 39. Программа переворачивает одномерный массив.
// [1 2 3 4 5] -> [5 4 3 2 1]

int[] arr = GetRandomArray(6);
PrintArray(arr);
PrintArray(Revers(arr));

// Метод переворачивает массив:
int[] Revers(int[] arr)
{
    int length = arr.Length;
    int [] result = new int[length];
    for(int i = 0; i<length; i++)
    {
        result[i] = arr[length-1-i];
    }
    return result;

}

// Метод создает рандомный одномерный массив чисел:
int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-99, 100);
    }
    return result;
}

// Метод выводит на печать заданный массив:
void PrintArray(int[] arr)
{
    System.Console.Write("В массиве: ");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    System.Console.WriteLine();
}


