// Напишите программу, которая на вводе принимает 2 числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите 2 числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine(num1 + ", " + num2 + "-> да");
}
else if (num2 * num2 == num1)
{
    Console.WriteLine(num2 + ", " + num1 + "-> да");
}
else
{
    Console.WriteLine(num1 + ", " + num2 + "-> нет");
}