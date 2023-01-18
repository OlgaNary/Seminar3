// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите номер дня недели (от 1 до 7)");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber != 1 && dayNumber != 2 && dayNumber != 3 && dayNumber != 4 && dayNumber != 5 && dayNumber != 6 && dayNumber != 7)
{
    System.Console.WriteLine("Вы ввели некорректное значение.");
}
else
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        System.Console.WriteLine("Это выходной день.");
    }
    else
    {
        System.Console.WriteLine("Это рабочий день.");
    }
}