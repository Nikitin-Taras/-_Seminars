// Напишите программу, которая на входе принимаетт число и проверяет, кратно ли оно одновременно и 7 и 23

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num  % 23 == 0 && num % 7 == 0)
{
    Console.Write(num + "-> да");
}
else
{
    Console.Write(num + "-> нет");
}