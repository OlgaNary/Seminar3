// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] arr = GetRandomArray(12);
PrintArray(arr);
System.Console.WriteLine(GetSummMoreZero(arr));
System.Console.WriteLine(GetSummLessZero(arr));


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
    System.Console.Write("Вы ввели массив: ");
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

// Метод нахождения суммы положительных элементов массива:
int GetSummMoreZero(int[] array)
{
    int result = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] >= 0)
        {
            result+=array[i];
        }
    }
    return result;
}

// Метод нахождения суммы отрицательных элементов массива:
int GetSummLessZero(int[] array)
{
    int result = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] < 0)
        {
            result+=array[i];
        }
    }
    return result;
}