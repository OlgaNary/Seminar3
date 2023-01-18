//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите любое целое число");
int num = Convert.ToInt32(Console.ReadLine());
int tempNum = num;
int count = 0;
while (tempNum != 0)
{
    tempNum = tempNum / 10;
    count++;
}
if (count < 3)
{
    System.Console.WriteLine($"В числе {num} нет третьей цифры.");
}
else
{
    count = count - 3;
    while (count != 0)
    {
        num = num / 10;
        count--;
    }
    System.Console.WriteLine($"Третья цифра в этом числе - {num % 10}");
}
