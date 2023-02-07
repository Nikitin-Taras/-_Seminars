// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j], 3}");
        }
        Console.WriteLine();
    }
}
int[,] GenerateArray(int n, int m){
    int[,] arr = new int[n, m];
    for(int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 10);
        }
    }
    return arr;
}
int[] ArrayToString(int[,] arr){
    int[] newArray = new int[arr.GetLength(0)*arr.GetLength(1)];
    int i = 0;
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                newArray[i] = arr[row, col];
                i++;
            }
        }
        return newArray.Distinct().ToArray();
        
   }


void FindQuantityOfEachElementVal(int[,] arr, int[] uniqueArray){
    int count;
    for (int i = 0; i < uniqueArray.Length; i++)
    {
        count = 0;
        int num = uniqueArray[i];
        Console.Write($"Quantity of {num} -> ");
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if(num == arr[row, col]){
                    count++;
                }
            }
            
        }
        Console.WriteLine(count);
        
    }
    
}

int n = new Random().Next(3, 4);
int m = new Random().Next(3, 4);
int[,] array = GenerateArray(n, m);
PrintArray(array);
Console.WriteLine();
int[] uniqueArray = ArrayToString(array);
FindQuantityOfEachElementVal(array, uniqueArray);


// Решение Олега

// Console.Write("Задайте количество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте количество столбцов: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите положительный числа\n");
// Console.Write("Задайте минимальные значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// // if (min < 0  max < 0  max < min)
// // {
// //     Console.Write("Некорректный ввод");
// //     return;
// // }

// int[,] array = new int[row, col];

// FillArray(array, min, max);
// PrintArray(array);
// int[] newArray = CountNumbersInArray(array, min, max);
// SpecialPrint(newArray, min);

// int[] CountNumbersInArray(int[,] arr, int min, int max)
// {
//     int[] counterArray = new int[max - min  + 1];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             counterArray[arr[i, j] + Math.Abs(min)]++;
//         }
//     }
//     return counterArray;
// }

// void SpecialPrint(int[] arr, int min)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == 0) continue;
//         Console.Write($"{i + min} = {arr[i]}\n");
//     }
// }


// void FillArray(int[,] arr, int min, int max)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(min, max + 1);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine("");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],3}");
//         }
//     }
//     Console.WriteLine("\n");
// }