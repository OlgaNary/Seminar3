//Программа принимает на вход число А и выдает сумму чтсел от 1 до А
//7->28
//4->10
//8->36
//int num1 = 7;
System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetSum(num1));
//Пишем метод (функцию)
int GetSum(int num)
{
    int res = 0;
    for(int i = 1; i <= num; i++)
    {
        res+=i;
    }
    return res;
}


