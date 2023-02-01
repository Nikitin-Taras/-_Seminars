// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[8];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9,10);
    Console.Write($"{arr[i]}, ");
    if (arr[i] == num) 
    Console.Write($"Заданное число  присутствует в массиве ");
    else Console.Write($"Заданное число не пристутствует в массиве");
}


