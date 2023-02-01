// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] arr = new int[8];


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-3,4);
    Console.Write($"{arr[i]}, ");
    arr[i] *= -1;
   
    Console.WriteLine($"{arr[i]}, ");
}
Console.WriteLine("\b\b ");

