//Задача 45. Программа создает копию заданнгого массива с помощью поэлементного копирования.


int[] arr = GetRandomArray(6);
PrintArray(arr);
int[] copyArr = GetCopyArray(arr);
PrintArray(copyArr);

//Создает копию массива:
int[] GetCopyArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for(int i=0; i<arr.Length; i++)
    {
        result[i] = arr[i];
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