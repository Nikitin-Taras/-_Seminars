// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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
void SwapLines(int[,] arr){
  
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          int temp = arr[0, j];
          arr[0,j] = arr[arr.GetLength(0)-1,j];
          arr[arr.GetLength(0)-1,j] = temp;  
        }
        

}
int n = new Random().Next(3, 4);
int m = new Random().Next(3, 4);
int[,] array = GenerateArray(n, m);
PrintArray(array);
Console.WriteLine();
SwapLines(array);
PrintArray(array);