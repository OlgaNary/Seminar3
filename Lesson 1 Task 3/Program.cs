// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) System.Console.WriteLine("Вы ввели чётное число");
else System.Console.WriteLine("Вы ввели нечётное число"); 