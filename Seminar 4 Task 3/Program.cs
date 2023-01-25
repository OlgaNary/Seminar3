// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
//PrintArray(GetRandomArray(8)); одновременно в вызове одного метода используется другой в качестве аргумента
//Можно задать вызов методов двумя строками:
int[] arr = GetRandomArray(10);
PrintArray(arr);
int[] GetRandomArray(int length)
{
    int[] result = new int[length];
    for (int i = 1; i < length; i++)
    {
        result[i] = new Random().Next(0, 2); //будет выводить только 0 и 1
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        //System.Console.WriteLine(item);
        System.Console.Write(item +" "); // Будет выводить в одну строку
    }
}
