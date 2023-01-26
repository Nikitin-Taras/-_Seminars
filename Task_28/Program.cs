// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

int Proizvedenie(int num)
{
    int res = 1;

    for (int i = 1; i <= num; i++)
    {
        res = res*i;
    }
    return res;
}

Console.WriteLine(Proizvedenie(A));
