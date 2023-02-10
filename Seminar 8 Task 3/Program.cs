//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
var arr = Generate2DArray(4, 4);
Print2DArray(arr);
System.Console.WriteLine();
System.Console.WriteLine();
var lionearArr = GetRowArray(arr);
PrintArray(lionearArr);
Array.Sort(lionearArr);
System.Console.WriteLine();
System.Console.WriteLine();
PrintArray(lionearArr);
System.Console.WriteLine();
System.Console.WriteLine();
GetCountOfEachElement(lionearArr);

void GetCountOfEachElement(int[] array)
{
    int el = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (el != array[i])
        {
            System.Console.WriteLine($"Element{el} count => {count}");
            count = 1;
            el = array[i];
        }
        else
        {
            count++;
        }
    }
}

int[] GetRowArray(int[,] arr)
{
    int[] result = new int[arr.GetLength(0) * arr.GetLength(1)];
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[index] = arr[i, j];
            index++;
        }
    }
    return result;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write(item);
    }
}