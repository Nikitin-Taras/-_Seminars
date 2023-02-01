// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = 0;
int b = 1;
int result = 0 ;
Console.Write($"{a}{b}");
for (int i = 0; i < num -2; i++)
{
    result = a + b;
    a = b;
    b = result; 
    Console.Write(result);
}

// Решение Людмилы

// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Если N = {num} -> ");

// int[] Fibonacci(int num)
// {
//     int[] array = new int[num];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i - 2] + array[i - 1];
//     }
//     return array;
// }
// Console.Write(string.Join(" ", Fibonacci(num)));