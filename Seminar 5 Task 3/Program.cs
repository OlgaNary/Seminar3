// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] arr = GetRandomArray(12);
PrintArray(arr);
System.Console.WriteLine(FindNum(10, arr));

// Метод определяет присутствует ли заданное число в массиве:
bool FindNum(int num, int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]==num)
        {
            return true;
        }
    }
    return false;
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