//Программа принимает число и выдает количество цифр в нем.
System.Console.WriteLine(GetCountNum(new Random().Next(1000, 100000)));
// Пишем метод
int GetCountNum(int num)
{
    System.Console.WriteLine(num);
    int count = 0;
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    return count;
}
