// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(console.ReadLine());

int num;
do
{
    Console.Clear();
    Console.Write("Введите число: ");
    num = Convert.ToInt32(Console.ReadLine()); 
} 
while(num<100 || num>1000);
Console.WriteLine($"result: {num%10}");
