// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] arr = new int[8];
// int multiply = 0;
// int Multiply()
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//     arr[i] = new Random().Next(1,100);
//     Console.Write($"{arr[i]}, ");
    
//     }
// }

// int[] array = new int[8];
// FillArray(array);
// ShowArray(array);



// void FillArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }
// }
// void ShowArray(int[] arr)
// {
//     for (int j = 0; j < arr.Length; j++)
//     {
//         int k = - 1;
//         Console.WriteLine(arr[j]*arr[k]);
//         k --;
//     }
// }

int[] arr = new int[new Random().Next(3, 12)];
int index = (arr.Length % 2 == 0) ? (arr.Length / 2) : (arr.Length / 2 + 1);
int[] arrM = new int[index];

Console.Write($"[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.Write($"{arr[i]} ");
}
Console.Write("] -> ");

for (int i = 0; i < arrM.Length; i++)
{
    if(i == (arr.Length - i - 1)) arrM[i] = arr[i];
    else    arrM[i] = arr[i] * arr[arr.Length - i - 1];
    Console.Write($"{arrM[i]} ");
}