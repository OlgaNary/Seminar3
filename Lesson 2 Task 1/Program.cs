System.Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вторая цифра числа - {(num/10) % 10}");