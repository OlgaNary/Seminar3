//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
System.Console.WriteLine("Введите любое целое число");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n;
int m = 0;
while (n1 > 0)
{
    m = m * 10 + n1 % 10;
    n1 = n1 / 10;
}
if (n == m)
{
    System.Console.WriteLine($"{n} является палиндромом - {m}");
}
else
{
    System.Console.WriteLine($"{n} не является палиндромом - {m}");
}
