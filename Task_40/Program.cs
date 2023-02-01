// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число C: ");
// int c = Convert.ToInt32(Console.ReadLine());

// void Triang (int a, int b, int c)
// {
//     if (a + b > c && a + c > b && b + c > a)
//     {
//     Console.WriteLine("Заданная фигура является треугольником");
//     }
//     else Console.WriteLine("Заданная фигура является треугольником");
// }

// Triang(a,b,c);

Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

// if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) Console.Write("Существует");
// else Console.Write("Не существует");

bool TriangleCheck(int n1, int n2, int n3)
{
    if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) return true;
    else return false;
}
if (TriangleCheck(n1, n2, n3)) Console.Write("Существует");
else Console.Write("Не существует");