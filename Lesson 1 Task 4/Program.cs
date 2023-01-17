//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
System.Console.WriteLine("Введите любое целое число");
int n = Convert.ToInt32(Console.ReadLine());
int currentNumber = 1;
while (currentNumber <= n)
{
    if (currentNumber%2 == 0) System.Console.Write(currentNumber + " ");
    currentNumber++;
}
