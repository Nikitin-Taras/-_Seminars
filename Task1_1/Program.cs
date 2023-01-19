// Напишите  программу которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго?
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int avg = num1*num1;

if (avg == num2)
{
    Console.WriteLine("Первое число является квадратом второго ");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго ");
};