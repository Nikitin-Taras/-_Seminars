// Напишите программу, которая на вход принимает одно число (N), а на выходе показываеет все целые числа в промежутке от -N до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = -1 * N;

while (current <= N)
{
    Console.Write($"{current}, ");
    current++;
}

Console.Write("\b\b  ");