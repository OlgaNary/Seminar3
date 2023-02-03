//Задача 44 Не используя рекурсию, выведите первые N чисел Фибоначи. Первые два числа Фибоначи 0 и 1
// Если N=5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int firstNum = 0;
int secondNum = 1;
int n = 10;
System.Console.WriteLine(firstNum);
System.Console.WriteLine(secondNum);
for (int i = 3; i <= n; i++)
{
    int currentNum = firstNum + secondNum;
    System.Console.WriteLine(currentNum);
    firstNum = secondNum;
    secondNum = currentNum;
}

