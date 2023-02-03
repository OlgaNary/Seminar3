// Программа принимает три числа и проверяет может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool CompareNum(int num1, int num2, int num3)
{
    return (((num1 + num2) > num3) && ((num1 + num3) > num2) && ((num2 + num3) > num1));
}
//int n1 = new Random().Next(0,10);
// int n2 = new Random().Next(0,10);
// int n3 = new Random().Next(0,10);
// System.Console.WriteLine($"{n1} {n2} {n3}");
System.Console.WriteLine(CompareNum(4,5,7));
