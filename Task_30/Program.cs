// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// void mas(){

// int[] mas = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     mas[i]=new Random().Next(0,2);
// }
// for (int i = 0; i < 8; i++)
// {
//     Console.Write(" "+mas[i]);
// }}
// mas();

int[] array = new int[8];
FillArray(array);
ShowArray(array);

void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}
void ShowArray(int[] arr)
{
    foreach (int element in arr)
    {
        Console.Write($"{element} ");
    }
}