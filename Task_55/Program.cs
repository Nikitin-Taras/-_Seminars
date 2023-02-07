// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
void ChangeRowAndCol(int[,] arr){

int start = 1;
    for(int i = 0; i < arr.GetLength(0)-1; i++){
        for (int j = start; j < arr.GetLength(1); j++)
        {
            int temp = arr[i, j];
            arr[i,j] = arr[j, i];
            arr[j, i] = temp;
        }
        start++;
    }
    PrintArray(arr);

}
int n = new Random().Next(6, 7);
int m = new Random().Next(6, 7);
int[,] array = GenerateArray(n, m);
PrintArray(array);
Console.WriteLine();
if(n != m){
    Console.WriteLine("Not possible to change");
}else{
    ChangeRowAndCol(array);
}