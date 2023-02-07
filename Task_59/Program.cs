// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[,] CreatNewArray(int[,] arr, int rowToDel, int colToDel){
    int[,] newArr = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    int rowNewArr = 0;
    int colNewArr = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i!=rowToDel || j!=colToDel){
                newArr[rowNewArr,colNewArr] = arr[i,j];
                colNewArr++;
            }

        }
        rowNewArr++;
    }
    return newArr;
}

int[,] FindMinElemAndCreatArray(int[,] arr){
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[minI,minJ] > arr[i,j]){
                minI = i;
                minJ = j;
            }
        }
    }
    return CreatNewArray(arr, minI, minJ);
}
int n = new Random().Next(4, 7);
int m = new Random().Next(4, 7);
int[,] array = GenerateArray(n, m);
PrintArray(array);
Console.WriteLine();
int[,] newArray = FindMinElemAndCreatArray(array);
PrintArray(newArray);